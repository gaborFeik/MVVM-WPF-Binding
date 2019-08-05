using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGarage2._0.Helper
{
   public class InvoiceGenerator
    {
        
        /// <summary>
        /// Static method for generating Invoice logic
        /// </summary>
        public  int GenerateInvoice()
        {
            Random random = new Random();
            var date = DateTime.Now.ToString("yyyyMMdd") + random.Next(10, 99);
            return Convert.ToInt32(date);
        }
    }
}
