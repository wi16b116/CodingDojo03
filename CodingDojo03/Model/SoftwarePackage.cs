using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo03.Model
{
    class SoftwarePackage
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public double SalesPrice { get; set; }
        public double PurchasePrice { get; set; }
        public int OnStock { get; set; }

        public SoftwarePackage(string name, string group, double salesPrice, double purchasePrice, int onStock)
        {
            this.Name = name;
            this.Group = group;
            this.SalesPrice = salesPrice;
            this.PurchasePrice = purchasePrice;
            this.OnStock = onStock;
        }

        
    }
}
