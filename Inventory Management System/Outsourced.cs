using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Outsourced : Part
    {
        public string companyName { get; set; }


        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName) 
            : base(partID, name, price, inStock, min, max)
        {
            this.companyName = companyName; 
        }
    }
 
}
