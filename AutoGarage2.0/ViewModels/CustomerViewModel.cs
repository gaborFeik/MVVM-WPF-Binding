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
        private int _phoneNumber ;
        private string _street;
        private string _houseNumber;
        private string _postcode;
        private string _city;

        /// <summary>
        /// Bound properties for creating a new Customer 
        /// </summary>

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

        public int PhoneNumber
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
        // Get full name from FirstName and LastName property
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        // Boolean linked method for enabling AddCustomer button
        public bool CanAddCustomer(string firstName, string lastName, int phoneNumber, string street, string houseNumber, string postcode, string city)
        {
            return
                !String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName) &&
                !String.IsNullOrWhiteSpace(phoneNumber.ToString()) && !String.IsNullOrWhiteSpace(street) &&
                !String.IsNullOrWhiteSpace(houseNumber) && !String.IsNullOrWhiteSpace(postcode) &&
                !String.IsNullOrWhiteSpace(city);
        }

        //  Method to add new  Customer and set empty properties
        public void AddCustomer(string firstName, string lastName, int phoneNumber, string street, string houseNumber, string postcode, string city)
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
