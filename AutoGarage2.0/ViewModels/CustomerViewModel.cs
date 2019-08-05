using AutoGarage2._0.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.ViewModels
{
   public class CustomerViewModel : Screen
    {
        private string _firstName;
        private string _lastName;
        private decimal _phoneNumber ;
        private string _street;
        private string _houseNumber;
        private string _postcode;
        private string _city;

        public CustomerViewModel()
        { Customers.Add(new CustomerModel { Id = 1, City = "asd", HouseNumber = "", PhoneNumber = 55, Postcode = "23", Street = "", FirstName = "Gabor", LastName = "Feik" }); ;
            Customers.Add(new CustomerModel { FirstName = "Ariel", LastName = "Kujawa" });
            Customers.Add(new CustomerModel { FirstName = "Tamas", LastName = "Czuprak" });
        }

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                NotifyOfPropertyChange(() => City);
            }
        }


        public string Postcode
        {
            get { return _postcode; }
            set
            { _postcode = value;
                NotifyOfPropertyChange(() => Postcode);
            }
        }


        public string HouseNumber
        {
            get { return _houseNumber; }
            set
            {
                _houseNumber = value;
                NotifyOfPropertyChange(() => HouseNumber);
            }
        }


        public string Street
        {
            get { return _street; }
            set
            {
                _street = value;
                NotifyOfPropertyChange(() => Street);
            }
        }

        public decimal PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                NotifyOfPropertyChange(() => PhoneNumber);
            }
        }


        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        private BindableCollection<CustomerModel> _customers = new BindableCollection<CustomerModel>();

        public BindableCollection<CustomerModel> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        private CustomerModel _selectedCustomer;
        public CustomerModel SelectedCustomer
        {
            get { return _selectedCustomer; }
            set {
                _selectedCustomer = value;
                NotifyOfPropertyChange(() => SelectedCustomer);
            }
        }
        public object ActivateItem { get; private set; }

        public bool CanAddClient(string firstName, string lastName, int phoneNumber, string street, string houseNumber, string postcode, string city)
        {
            
            return
                !String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName) &&
                phoneNumber >= 1 && phoneNumber.ToString().Length >= 9 && !String.IsNullOrWhiteSpace(street) &&
                !String.IsNullOrWhiteSpace(houseNumber) && !String.IsNullOrWhiteSpace(postcode) &&
                !String.IsNullOrWhiteSpace(city);
        }

        public void AddClient(string firstName, string lastName, int phoneNumber, string street, string houseNumber, string postcode, string city)
        {
            FirstName = "";
            LastName = "";
            PhoneNumber = 0;
            Street = "";
            HouseNumber = "";
            Postcode = "";
            City = "";
             
        }
    }
}
