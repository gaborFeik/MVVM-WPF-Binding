using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.Models
{
  public  class OrderModel
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime OrderTime { get; set; }
        public bool TaxAble { get; set; }
        public virtual ICollection<ServiceModel> ServiceModels { get; set; }
        public virtual CustomerModel CustomerModel { get; set; }

    }
}
