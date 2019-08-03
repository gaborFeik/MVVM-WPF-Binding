using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.Models
{
  public  class OrderModel
    {
        public int OrderId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime OrderTime { get; set; }
        public int CustomerId { get; set; }
        public List<ServiceModel> OrderServices { get; set; }

    }
}
