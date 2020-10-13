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
    public partial class ModifyPart : Form
    {
        bool validated = false;
        bool NameValid = false;
        bool InventoryValid = false;
        bool PriceCostValid = false;
        bool MinValid = false;
        bool MaxValid = false;
        bool MachineCompanyValid = false;


        public ModifyPart(InHouse inHouse)
        {
            InitializeComponent();
            rdoInHouse.Checked = true;
            txtID.Text = inHouse.PartID.ToString();
            txtName.Text = inHouse.Name.ToString();
            txtInventory.Text = inHouse.InStock.ToString();
            txtPriceCost.Text = inHouse.Price.ToString();
            txtMin.Text = inHouse.Min.ToString();
            txtMax.Text = inHouse.Max.ToString();
            txtMachineCompany.Text = inHouse.machineID.ToString();
        }
        public ModifyPart(Outsourced outsourced)
        {
            InitializeComponent();
            rdoOutscourced.Checked = true; 
            txtID.Text = outsourced.PartID.ToString();
            txtName.Text = outsourced.Name.ToString();
            txtInventory.Text = outsourced.InStock.ToString();
            txtPriceCost.Text = outsourced.Price.ToString();
            txtMin.Text = outsourced.Min.ToString();
            txtMax.Text = outsourced.Max.ToString();
            txtMachineCompany.Text = outsourced.companyName;
        }

        private void Validate()
        {
            if (NameValid == true && InventoryValid == true && PriceCostValid == true && MinValid == true && MaxValid == true && MachineCompanyValid == true)
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

        private void txtPriceCost_TextChanged(object sender, EventArgs e)
        {
            decimal numberCheck;
            if (decimal.TryParse(txtPriceCost.Text, out numberCheck))
            {
                txtPriceCost.BackColor = System.Drawing.Color.White;
                PriceCostValid = true;
            }
            else
            {
                txtPriceCost.BackColor = System.Drawing.Color.Salmon;
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

        private void txtMachineCompany_TextChanged(object sender, EventArgs e)
        {
            if (rdoOutscourced.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtMachineCompany.Text))
                {
                    txtMachineCompany.BackColor = System.Drawing.Color.White;
                    MachineCompanyValid = true;
                }
                else
                {
                    txtMachineCompany.BackColor = System.Drawing.Color.Salmon;
                    MachineCompanyValid = false;
                }
            }

            if (rdoInHouse.Checked)
            {
                int numberCheck;
                if (int.TryParse(txtMachineCompany.Text, out numberCheck))
                {
                    txtMachineCompany.BackColor = System.Drawing.Color.White;
                    MachineCompanyValid = true;
                }
                else
                {
                    txtMachineCompany.BackColor = System.Drawing.Color.Salmon;
                    MachineCompanyValid = false;
                }
            }
        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineCompany.Text = "Company ID";
        }

        private void rdoOutscourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineCompany.Text = "Machine ID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validate();
            if (validated == true)
            {
                if (rdoInHouse.Checked)
                {
                    InHouse inHouse = new InHouse(Int32.Parse(txtID.Text), txtName.Text, Int32.Parse(txtPriceCost.Text), Int32.Parse(txtInventory.Text), Int32.Parse(txtMin.Text), Int32.Parse(txtMax.Text), Int32.Parse(txtMachineCompany.Text));
                    Inventory.updatePart(Int32.Parse(txtID.Text), inHouse);

                }
                else
                {
                    Outsourced outsourced = new Outsourced(Int32.Parse(txtID.Text), txtName.Text, Int32.Parse(txtPriceCost.Text), Int32.Parse(txtInventory.Text), Int32.Parse(txtMin.Text), Int32.Parse(txtMax.Text), txtMachineCompany.Text);
                    Inventory.updatePart(Int32.Parse(txtID.Text), outsourced);

                }
                this.Close();
            }
            else
            {
                txtWarning.Visible = true;
            }
        }
    }
}
