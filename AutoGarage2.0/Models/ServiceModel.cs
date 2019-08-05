using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.Models
{
   public class ServiceModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public virtual OrderModel OrderModel { get; set; }
    }
}
