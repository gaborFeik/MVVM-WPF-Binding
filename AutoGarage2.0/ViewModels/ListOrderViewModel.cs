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
    public class ListOrderViewModel : Screen
    {
        private BindableCollection<OrderModel> _listOrders = new BindableCollection<OrderModel>();

        /// <summary>
        /// Constractor setting up some test data.
        /// </summary>
        public ListOrderViewModel()
        {
            // TestData
            for (int i = 0; i < 50; i++)
            {
                ListOrders.Add(new OrderModel
                {
                    CustomerModel = new CustomerModel { FirstName="Son", LastName="Goku"},
                    InvoiceNumber =  new InvoiceGenerator().GenerateInvoice(),
                    Id = 1,
                    OrderTime = DateTime.Now,
                    TaxAble = false,
                    ServiceModels = new List<ServiceModel> { new ServiceModel { Cost= 25+i, Description="TestRecord"+ i}, new ServiceModel { Cost = 25 + i*2, Description = "TestRecord" + i*3 } }

                });
            }

       //     FListOrders = ListOrders;

        }
        //private BindableCollection<OrderModel> _fListOrders = new BindableCollection<OrderModel>();

        //public BindableCollection<OrderModel> FListOrders
        //{
        //    get { return FListOrders; }
        //    set {
        //        FListOrders = value;
        //        NotifyOfPropertyChange(() => FListOrders);
        //    }
        //}


        //Binding collectiong for List orders
        public BindableCollection<OrderModel> ListOrders
        {
            get { return _listOrders; }
            set
            {
                _listOrders = value;
                NotifyOfPropertyChange(() => ListOrders);
            }
        }

        // Binding model for selected item from collection
        private OrderModel _selectedOrder;

        public OrderModel SelectedOrder
        {
            get { return _selectedOrder; }
            set {
                _selectedOrder = value;
                NotifyOfPropertyChange(() => SelectedOrder);
            }
        }

    }
}
