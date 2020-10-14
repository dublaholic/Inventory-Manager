using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> tempParts = new BindingList<Part>();

        bool validated = false;
        bool NameValid = false;
        bool InventoryValid = false;
        bool PriceCostValid = false;
        bool MinValid = false;
        bool MaxValid = false;
        public ModifyProduct(Product ModProduct)
        {
            InitializeComponent();

            txtID.Text = ModProduct.productID.ToString();
            txtName.Text = ModProduct.name.ToString();
            txtInventory.Text = ModProduct.inStock.ToString();
            txtPrice.Text = ModProduct.price.ToString();
            txtMin.Text = ModProduct.min.ToString();
            txtMax.Text = ModProduct.max.ToString();
            tempParts = ModProduct.associatedParts;
            ProductsScreenLoad();
            formatDGV(dgvCandidateParts);
            formatDGV(dgvAssociatedProducts);

        }
        public void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
        }
        public void ProductsScreenLoad()
        {
            dgvCandidateParts.DataSource = Inventory.AllParts;
            dgvAssociatedProducts.DataSource = tempParts;
            

        }
        private void Validate()
        {
            if (NameValid == true && InventoryValid == true && PriceCostValid == true && MinValid == true && MaxValid == true)
            {
                validated = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.BackColor = System.Drawing.Color.White;
                NameValid = true;
            }
            else
            {
                txtName.BackColor = System.Drawing.Color.Salmon;
                NameValid = false;
            }
        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {
            int numberCheck;
            if (int.TryParse(txtInventory.Text, out numberCheck))
            {
                txtInventory.BackColor = System.Drawing.Color.White;
                InventoryValid = true;
            }
            else
            {
                txtInventory.BackColor = System.Drawing.Color.Salmon;
                InventoryValid = false;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            decimal numberCheck;
            if (decimal.TryParse(txtPrice.Text, out numberCheck))
            {
                txtPrice.BackColor = System.Drawing.Color.White;
                PriceCostValid = true;
            }
            else
            {
                txtPrice.BackColor = System.Drawing.Color.Salmon;
                PriceCostValid = false;
            }
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            int numberCheck;
            if (int.TryParse(txtMax.Text, out numberCheck))
            {
                txtMax.BackColor = System.Drawing.Color.White;
                MaxValid = true;
            }
            else
            {
                txtMax.BackColor = System.Drawing.Color.Salmon;
                MaxValid = false;
            }
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            int numberCheck;
            if (int.TryParse(txtMin.Text, out numberCheck))
            {
                txtMin.BackColor = System.Drawing.Color.White;
                MinValid = true;
            }
            else
            {
                txtMin.BackColor = System.Drawing.Color.Salmon;
                MinValid = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCandidateParts.ClearSelection();
            dgvCandidateParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            if (txtSearch.Text == "")
            {
                return;
            }

            Part PartMatch = Inventory.LookUpPart(txtSearch.Text.ToUpper());

            foreach (DataGridViewRow row in dgvCandidateParts.Rows)
            {
                Part partsearch = (Part)row.DataBoundItem;
                if (partsearch.Name == PartMatch.Name)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAssociatedProducts.SelectedRows)
            {
                dgvAssociatedProducts.Rows.RemoveAt(row.Index);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validate();
            if (validated == true)
            {
                Product productToUpdate = new Product((Inventory.AllProducts.Count + 1), txtName.Text, decimal.Parse(txtPrice.Text), Int32.Parse(txtInventory.Text), Int32.Parse(txtMin.Text), Int32.Parse(txtMax.Text), tempParts);
                Inventory.UpdateProduct(Int32.Parse(txtID.Text), productToUpdate);
                this.Close();

            }
            else
            {
                txtWarning.Visible = true;
            }
            this.Close();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Part partToProduct = (Part)dgvCandidateParts.CurrentRow.DataBoundItem;
            tempParts.Add(partToProduct);
        }
    }
    
}
