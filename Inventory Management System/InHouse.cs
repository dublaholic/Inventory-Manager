using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class InHouse : Part
    {
        public int machineID{ get; set; }


        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
           : base(partID, name, price, inStock, min, max)
        {
            this.machineID = machineID;
        }
    }
}
