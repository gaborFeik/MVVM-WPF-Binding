using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.Models
{
   public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal PhoneNumber { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public virtual ICollection<OrderModel> OrderModels { get; set; }


    }
}
