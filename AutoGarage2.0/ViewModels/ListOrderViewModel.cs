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
            List<ServiceModel> serviceModels = new List<ServiceModel>();
            serviceModels.Add(  new ServiceModel{Cost=50, Description= "Brake",ServiceId = 1 });
            serviceModels.Add(  new ServiceModel{Cost=150, Description= "Fluid",ServiceId = 2 });
            List<ServiceModel> serviceModels2 = new List<ServiceModel>();
            serviceModels2.Add(new ServiceModel { Cost = 500, Description = "Motor", ServiceId = 1 });
            serviceModels2.Add(new ServiceModel { Cost = 1500, Description = "Element", ServiceId = 2 });
            ListOrders.Add(new OrderModel
            {
                CustomerId = 1,
                InvoiceNumber = 2345667,
                OrderId = 1,
                OrderTime = DateTime.Now,
                OrderServices = serviceModels
            } );
            ListOrders.Add(new OrderModel
            {
                CustomerId = 2,
                InvoiceNumber = 2345667,
                OrderId = 2,
                OrderTime = DateTime.Now,
                OrderServices = serviceModels2
            });
        }

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
    }
}
