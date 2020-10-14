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

        public Product(int ProductID, string Name, decimal Price, int InStock, int Min, int Max, BindingList<Part> AssociatedParts)
        {

            this.productID = ProductID;
            this.name = Name;
            this.price = Price;
            this.inStock = InStock;
            this.min = Min;
            this.max = Max;
            this.associatedParts = AssociatedParts;
        }


        public BindingList<Part> associatedParts { get; set; } = new BindingList<Part>();
        public int productID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int inStock { get; set; }
        public int min { get; set; }
        public int max { get; set; }


        public void AddAssociatedPart(Part part)
        {
            associatedParts.Add(part);
            
        }
        public bool removeAssociatedPart(int partID)
        {
            bool remove = false;
            foreach (Part part in associatedParts)
            {
                if (part.PartID == partID)
                {
                    associatedParts.Add(part);
                    return remove = true;
                }
                else
                {
                    return false;
                }
            }
            return remove;
        }
        public Part LookupAssociatedPart(int partID)
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
