namespace Inventory_Management_System
{
    partial class Parts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rdoInHouse = new System.Windows.Forms.RadioButton();
            this.rdoOutscourced = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMachineCompany = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMachineCompany = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // rdoInHouse
            // 
            this.rdoInHouse.AutoSize = true;
            this.rdoInHouse.Location = new System.Drawing.Point(91, 27);
            this.rdoInHouse.Name = "rdoInHouse";
            this.rdoInHouse.Size = new System.Drawing.Size(68, 17);
            this.rdoInHouse.TabIndex = 1;
            this.rdoInHouse.TabStop = true;
            this.rdoInHouse.Text = "In-House";
            this.rdoInHouse.UseVisualStyleBackColor = true;
            this.rdoInHouse.CheckedChanged += new System.EventHandler(this.rdoInHouse_CheckedChanged);
            // 
            // rdoOutscourced
            // 
            this.rdoOutscourced.AutoSize = true;
            this.rdoOutscourced.Location = new System.Drawing.Point(170, 27);
            this.rdoOutscourced.Name = "rdoOutscourced";
            this.rdoOutscourced.Size = new System.Drawing.Size(80, 17);
            this.rdoOutscourced.TabIndex = 2;
            this.rdoOutscourced.TabStop = true;
            this.rdoOutscourced.Text = "Outsourced";
            this.rdoOutscourced.UseVisualStyleBackColor = true;
            this.rdoOutscourced.CheckedChanged += new System.EventHandler(this.rdoOutscourced_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min";
            // 
            // lblMachineCompany
            // 
            this.lblMachineCompany.AutoSize = true;
            this.lblMachineCompany.Location = new System.Drawing.Point(26, 256);
            this.lblMachineCompany.Name = "lblMachineCompany";
            this.lblMachineCompany.Size = new System.Drawing.Size(62, 13);
            this.lblMachineCompany.TabIndex = 9;
            this.lblMachineCompany.Text = "Machine ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(95, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Salmon;
            this.txtName.Location = new System.Drawing.Point(95, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtInventory
            // 
            this.txtInventory.BackColor = System.Drawing.Color.Salmon;
            this.txtInventory.Location = new System.Drawing.Point(95, 131);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(100, 20);
            this.txtInventory.TabIndex = 12;
            this.txtInventory.TextChanged += new System.EventHandler(this.txtInventory_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Salmon;
            this.txtPrice.Location = new System.Drawing.Point(95, 163);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.Salmon;
            this.txtMax.Location = new System.Drawing.Point(95, 210);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(64, 20);
            this.txtMax.TabIndex = 14;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Salmon;
            this.txtMin.Location = new System.Drawing.Point(212, 210);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(58, 20);
            this.txtMin.TabIndex = 15;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMachineCompany
            // 
            this.txtMachineCompany.BackColor = System.Drawing.Color.Salmon;
            this.txtMachineCompany.Location = new System.Drawing.Point(120, 249);
            this.txtMachineCompany.Name = "txtMachineCompany";
            this.txtMachineCompany.Size = new System.Drawing.Size(100, 20);
            this.txtMachineCompany.TabIndex = 16;
            this.txtMachineCompany.TextChanged += new System.EventHandler(this.txtMachineCompany_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtWarning
            // 
            this.txtWarning.AutoSize = true;
            this.txtWarning.ForeColor = System.Drawing.Color.Red;
            this.txtWarning.Location = new System.Drawing.Point(61, 358);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(166, 13);
            this.txtWarning.TabIndex = 19;
            this.txtWarning.Text = "Please complete all required fields";
            this.txtWarning.Visible = false;
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 380);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMachineCompany);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMachineCompany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoOutscourced);
            this.Controls.Add(this.rdoInHouse);
            this.Controls.Add(this.label1);
            this.Name = "Parts";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoInHouse;
        private System.Windows.Forms.RadioButton rdoOutscourced;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMachineCompany;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMachineCompany;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtWarning;
    }
}