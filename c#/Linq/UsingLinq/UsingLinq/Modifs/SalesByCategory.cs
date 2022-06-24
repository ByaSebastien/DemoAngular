using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLinq.Models
{
    public partial class SalesByCategory
    {
        public override string ToString()
        {
            return $"{CategoryId} {CategoryName,-20} {ProductName,-35} {ProductSales,15:C}";
        }
    }
}
