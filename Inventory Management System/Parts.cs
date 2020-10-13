using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Management_System
{
    public partial class Parts : Form
    {
        bool validated = false;
        bool NameValid = false;
        bool InventoryValid = false;
        bool PriceCostValid = false;
        bool MinValid = false;
        bool MaxValid = false;
        bool MachineCompanyValid = false;
        
        public Parts()
        {
            InitializeComponent();
            int partid = Inventory.AllParts.Count + 1;
            txtID.Text = partid.ToString();
        }

        private void Validate()
        {
            if(NameValid == true && InventoryValid == true && PriceCostValid == true && MinValid == true && MaxValid == true && MachineCompanyValid == true)
            {
                validated = true;
            }
        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineCompany.Text = "Machine ID";
        }

        private void rdoOutscourced_CheckedChanged(object sender, EventArgs e)

        {
            lblMachineCompany.Text = "Company ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validate();
            if (validated == true)
            {
                if (rdoInHouse.Checked)
                {
                    InHouse inHouse = new InHouse((Inventory.AllParts.Count + 1), txtName.Text, Int32.Parse(txtPrice.Text), Int32.Parse(txtInventory.Text), Int32.Parse(txtMin.Text), Int32.Parse(txtMax.Text), Int32.Parse(txtMachineCompany.Text));
                    Inventory.addPart(inHouse);

                }
                else
                {
                    Outsourced outsourced = new Outsourced((Inventory.AllParts.Count + 1), txtName.Text, Int32.Parse(txtPrice.Text), Int32.Parse(txtInventory.Text), Int32.Parse(txtMin.Text), Int32.Parse(txtMax.Text), txtMachineCompany.Text);
                    Inventory.addPart(outsourced);

                }
                this.Close();
            }
            else
            {
                txtWarning.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
