using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.ViewModels
{
   public class MainViewModel : Conductor<object>
    {
        /// <summary>
        /// Menu Button methods for setting ContentControl
        /// </summary>
        public void LoadCustomerView()
        {
            ActivateItem(new CustomerViewModel());
        }

        public void LoadOrderView()
        {
            ActivateItem(new OrderViewModel());
        }

        public void LoadCustomerListView()
        {
            ActivateItem(new ListCustomerViewModel());
        }
        public void LoadOrderListView()
        {
            ActivateItem(new ListOrderViewModel());
        }

    }
}
