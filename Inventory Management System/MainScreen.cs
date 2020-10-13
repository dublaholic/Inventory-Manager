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
    public partial class FRMMainScreen : Form
    {
        public FRMMainScreen()
        {
            InitializeComponent();
            formatDGV(dgvParts);
            formatDGV(dgvProducts);
            Inventory.BuildList();
        }

        private void FRMMainScreen_Load(object sender, EventArgs e)
        {
            display();
        }

        private void formatDGV(DataGridView d)
        {
            
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
        }


        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dgvParts.CurrentCell.RowIndex;
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentIndex = dgvProducts.CurrentCell.RowIndex;
        }


        private void display()
        {
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.AllProducts;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPartAdd_Click(object sender, EventArgs e)
        {
            new Parts().ShowDialog();

        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            
            if(txtPartSearch.Text == "")
            {
                return;
            }
            
            Part PartMatch = Inventory.LookUpPart(txtPartSearch.Text.ToUpper());

            foreach(DataGridViewRow row in dgvParts.Rows)
            {
                Part partsearch = (Part)row.DataBoundItem;
                if(partsearch.Name == PartMatch.Name)
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

        private void btnPartDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow SelectedRow = dgvParts.SelectedRows[0];
            string PartItem = SelectedRow.Cells[1].Value.ToString();
            Part PartDelete = Inventory.PartMatch(PartItem.ToUpper());
            Inventory.deletePart(PartDelete);
            dgvParts.Refresh();


        }

        private void btnPartModify_Click(object sender, EventArgs e)
        {
            if(dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inHouse = (InHouse)dgvParts.CurrentRow.DataBoundItem;
                new ModifyPart(inHouse).ShowDialog();
            }
            else
            {
                Outsourced outsourced = (Outsourced)dgvParts.CurrentRow.DataBoundItem;
                new ModifyPart(outsourced).ShowDialog();
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            new Products().ShowDialog();
        }

        private void btnProductModify_Click(object sender, EventArgs e)
        {
            Product ModProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            new ModifyProduct(ModProduct).ShowDialog();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow SelectedRow = dgvProducts.SelectedRows[0];
            string prodItem = SelectedRow.Cells[0].Value.ToString();
            
            Inventory.removeProduct(Int32.Parse(prodItem));
            dgvProducts.Refresh();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            if (txtProductSearch.Text == "")
            {
                return;
            }

            Product ProdMatch = Inventory.LookUpProduct(txtProductSearch.Text.ToUpper());

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                Product prodSearch = (Product)row.DataBoundItem;
                if (prodSearch.name == ProdMatch.name)
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
    }
}


