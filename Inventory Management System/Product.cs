using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Product
    {

        public Product(int ProductID, string Name, decimal Price, int inStock, int Min, int Max, )
        {
            
            this.productID = ProductID;
            this.name = Name;
            this.price = Price;
            this.InStock = inStock;
            this.min = Min;
            this.max = Max;
            
            

        }


        public static BindingList<Part> associatedParts = new BindingList<Part>();
        public int productID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int InStock { get; set; }
        public int min { get; set; }
        public int max { get; set; }


        public static void AddAssociatedPart(Part part)
        {
            associatedParts.Add(part);
        }
        public static bool removeAssociatedPart(int partID)
        {
            bool remove = false;
            foreach (Part part in associatedParts)
            {
                if (part.PartID == partID)
                {
                    associatedParts.Remove(part);
                    return remove = true;
                }
                else
                {
                    return false;
                }
            }
            return remove;
        }
        public static Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in associatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = null;
            return emptyPart;
        }

    }

}
