using AutoGarage2._0.Helper;
using AutoGarage2._0.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.ViewModels
{
   public class OrderViewModel : Screen 
    {
        
        // Setting private fields for the bind properties
        private int _orderId;
        private int _invoiceNumber = new InvoiceGenerator().GenerateInvoice();
        private DateTime _orderTime = DateTime.Now;
        private bool _taxAble;
        private int _customerId;
        private string _customerName = "";
        private BindableCollection<ServiceModel> _orderServices = new BindableCollection<ServiceModel>();
        private BindableCollection<CustomerModel> _fCustomers = new BindableCollection<CustomerModel>();
        private BindableCollection<CustomerModel> _customerRepository = new BindableCollection<CustomerModel>();
        private ServiceModel _service = new ServiceModel();
        private CustomerModel _selectedCustomer = new CustomerModel();
        private ServiceModel _selectedService;

        /// <summary>
        /// Constractor gets repository
        /// </summary>
        public OrderViewModel()
        {
            CustomerRepository.Add(new CustomerModel { FirstName = "Son", LastName = "Goku" });
            CustomerRepository.Add(new CustomerModel { FirstName = "Prince", LastName = "Vegeta" });
            CustomerRepository.Add(new CustomerModel { FirstName = "Zeno", LastName = "Sama" });
            CustomerRepository.Add(new CustomerModel { FirstName = "Lord", LastName = "Beerus" });
            CustomerRepository.Add(new CustomerModel { FirstName = "Angel", LastName = "Whis" });
        }

        #region Bindable Properties
        // Model Properties
        public int OrderId
        {
            get { return _orderId; }
            set {
                _orderId = value;
                NotifyOfPropertyChange(() => OrderId);
            }
        }

        public int InvoiceNumber
        {
            get { return _invoiceNumber; }
            set {
                NotifyOfPropertyChange(() => InvoiceNumber);
                if (value.ToString().Length >= 9)
                {
                    _invoiceNumber = value;
                }
                NotifyOfPropertyChange(() => InvoiceNumber);
            }
        }

        public DateTime OrderTime
        {
            get { return _orderTime; }
            set {
                _orderTime = value;
                NotifyOfPropertyChange(() => OrderTime);
            }
        }

        public bool Taxable
        {
            get { return _taxAble; }
            set
            {
                _taxAble = value;
                NotifyOfPropertyChange(() => Taxable);
            }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set
            {
                _customerId = value;
                NotifyOfPropertyChange(() => CustomerId);
            }
        }

        public BindableCollection<ServiceModel> OrderServices
        {
            get { return _orderServices; }
            set
            {
                _orderServices = value;
                NotifyOfPropertyChange(() => OrderServices);

            }
        }

        #endregion

        // Bound CustomerName property with logic to filter Listbox itemsource
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                _customerName = value;
                FCustomers.Clear();
                NotifyOfPropertyChange(() => CustomerName);
                foreach (var item in CustomerRepository)
                {
                    if ((item.FullName.ToLower()).Contains(CustomerName.ToLower()))
                    {
                        FCustomers.Add(item);
                        NotifyOfPropertyChange(() => FCustomers);

                    }

                }
            }
        }

        // Binding service model for OrderModel's List services

        public ServiceModel Service
        {
            get
            {
                return _service;
            }
            set
            {
                _service = value;
                NotifyOfPropertyChange(() => Service);
            }
        }

        // Filtered customer collection for Listbox controlled by CustomerName property
        public BindableCollection<CustomerModel> FCustomers
        {
            get { return _fCustomers; }
            set {
                _fCustomers = value;
            }
        }

        // Repository for later improvement

        public BindableCollection<CustomerModel> CustomerRepository
        {
            get { return _customerRepository; }
            set
            {
                _customerRepository = value;
            }
        }

        // Full property for selected customer model

        public CustomerModel SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                NotifyOfPropertyChange(() => SelectedCustomer);
                NotifyOfPropertyChange(() => CanExportPdf);
                NotifyOfPropertyChange(() => CanAddOrder);
                

            }
        }

        // Full property for selected service model

        public ServiceModel SelectedService
        {
            get { return _selectedService; }
            set
            {
                _selectedService = value;
                NotifyOfPropertyChange(() => SelectedService);
            }
        }

        /// <summary>
        /// Button Methods
        /// </summary>
        #region Button Methods

        // Name convention for enabling AddService button

        public bool CanAddService(double service_Cost, string service_Description)
        {
            return
              Convert.ToBoolean(service_Cost) && !String.IsNullOrWhiteSpace(service_Description);
        }

        // Adds the bound service model to the List

         public void AddService(double service_Cost,string service_Description)
        {
            OrderServices.Add(new ServiceModel { Description = service_Description, Cost = service_Cost });
            NotifyOfPropertyChange(() => OrderServices);
            NotifyOfPropertyChange(() => CanExportPdf);
            NotifyOfPropertyChange(() => CanAddOrder);


        }

        // Remove the bound SelectedService object from the Service list

        public void RemoveService()
        {
            OrderServices.Remove(SelectedService);
            NotifyOfPropertyChange(() => CanExportPdf);
            NotifyOfPropertyChange(() => CanAddOrder);
        }

        public bool CanAddOrder
        {
            get
            {
                if (OrderServices.Count > 0 && SelectedCustomer.FullName != "")
                {
                    return true;
                }
                return false;
            }
        }

        // Call repository to AddOrder Method

        public void AddOrder(OrderModel order)
        {

        }

        // Calling can execute static export class
        public bool CanExportPdf
        {
            get{
                if (OrderServices.Count > 0 && SelectedCustomer.FullName != "")
                {
                    return true;
                }
                return false;
            }
        }

        // Calling static export class
        public void ExportPdf( )
        {
            InvoicePdfConverter.PdfExport(this);
        }
        #endregion
    }
}
