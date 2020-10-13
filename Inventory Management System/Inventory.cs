using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> AllProducts = new BindingList<Product>();

        public static int CurrentIndex { get; set; }

        public static void BuildList()
        {
            Inventory.AllParts.Clear();


        }
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }
        public static void addProduct(Product product)
        {
            AllProducts.Add(product);
        }

        public static Part LookUpPart(String partName)
        {
            foreach(Part part in AllParts)
            {
                if (part.Name.ToUpper().Contains(partName))
                {
                    return part;
                }
            }
            Part emptyPart = null;
            return emptyPart;

        }
        public static Product LookUpProduct(String ProdName)
        {
            foreach (Product prod in AllProducts)
            {
                if (prod.name.ToUpper().Contains(ProdName))
                {
                    return prod;
                }
            }
            Product emptyProd = null;
            return emptyProd;

        }

        public static Part PartMatch(String partName)
        {
            foreach(Part part in AllParts)
            {
                if (part.Name.ToUpper() == partName)
                {
                    return part; 
                }
            }
            Part emptyPart = null;
            return emptyPart;
        }

        public static bool deletePart(Part part)
        {
            try
            {
                AllParts.Remove(PartMatch(part.Name.ToUpper()));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool removeProduct(int productID)
        {
            bool remove = false;
            foreach(Product prodToRemove in AllProducts)
            {
                if(productID == prodToRemove.productID)
                {
                    AllProducts.Remove(prodToRemove);
                    return remove = true;
                }
                else
                {
                    MessageBox.Show("Failed to Remove");
                        return false;  
                }
            }
            return remove;
        }
        public static void updatePart(int partID, Part replacementPart)
        {
            
            foreach(Part oldPart in AllParts)
            {
                if(oldPart.PartID == partID)
                {
                    int index = AllParts.IndexOf(oldPart);
                    AllParts[index] = replacementPart;
                    return;             
                }
            }
        }
        public static void UpdateProduct(int prodID, Product replacementProd)
        {
            foreach(Product oldProd in AllProducts)
            {
                if (oldProd.productID == prodID)
                {
                    int index = AllProducts.IndexOf(oldProd);
                    AllProducts[index] = replacementProd;
                    return;
                }
            }
        }
    
    }
}

