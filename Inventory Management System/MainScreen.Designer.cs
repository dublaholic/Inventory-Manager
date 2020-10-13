namespace Inventory_Management_System
{
    partial class FRMMainScreen
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.txtPartSearch = new System.Windows.Forms.RichTextBox();
            this.txtProductSearch = new System.Windows.Forms.RichTextBox();
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartModify = new System.Windows.Forms.Button();
            this.btnPartDelete = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductModify = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(16, 116);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(591, 366);
            this.dgvParts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(641, 116);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(610, 366);
            this.dgvProducts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Location = new System.Drawing.Point(374, 87);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPartSearch.TabIndex = 5;
            this.btnPartSearch.Text = "Search";
            this.btnPartSearch.UseVisualStyleBackColor = true;
            this.btnPartSearch.Click += new System.EventHandler(this.btnPartSearch_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(1015, 89);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProductSearch.TabIndex = 6;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(465, 87);
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(145, 23);
            this.txtPartSearch.TabIndex = 7;
            this.txtPartSearch.Text = "";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(1106, 89);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(145, 23);
            this.txtProductSearch.TabIndex = 8;
            this.txtProductSearch.Text = "";
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.Location = new System.Drawing.Point(373, 488);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPartAdd.TabIndex = 9;
            this.btnPartAdd.Text = "Add";
            this.btnPartAdd.UseVisualStyleBackColor = true;
            this.btnPartAdd.Click += new System.EventHandler(this.btnPartAdd_Click);
            // 
            // btnPartModify
            // 
            this.btnPartModify.Location = new System.Drawing.Point(454, 488);
            this.btnPartModify.Name = "btnPartModify";
            this.btnPartModify.Size = new System.Drawing.Size(75, 23);
            this.btnPartModify.TabIndex = 10;
            this.btnPartModify.Text = "Modify";
            this.btnPartModify.UseVisualStyleBackColor = true;
            this.btnPartModify.Click += new System.EventHandler(this.btnPartModify_Click);
            // 
            // btnPartDelete
            // 
            this.btnPartDelete.Location = new System.Drawing.Point(535, 488);
            this.btnPartDelete.Name = "btnPartDelete";
            this.btnPartDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPartDelete.TabIndex = 11;
            this.btnPartDelete.Text = "Delete";
            this.btnPartDelete.UseVisualStyleBackColor = true;
            this.btnPartDelete.Click += new System.EventHandler(this.btnPartDelete_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(1175, 488);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 14;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductModify
            // 
            this.btnProductModify.Location = new System.Drawing.Point(1094, 488);
            this.btnProductModify.Name = "btnProductModify";
            this.btnProductModify.Size = new System.Drawing.Size(75, 23);
            this.btnProductModify.TabIndex = 13;
            this.btnProductModify.Text = "Modify";
            this.btnProductModify.UseVisualStyleBackColor = true;
            this.btnProductModify.Click += new System.EventHandler(this.btnProductModify_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(1013, 488);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 12;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1175, 567);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FRMMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 634);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductModify);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.btnPartDelete);
            this.Controls.Add(this.btnPartModify);
            this.Controls.Add(this.btnPartAdd);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.txtPartSearch);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label1);
            this.Name = "FRMMainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.FRMMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.RichTextBox txtPartSearch;
        private System.Windows.Forms.RichTextBox txtProductSearch;
        private System.Windows.Forms.Button btnPartAdd;
        private System.Windows.Forms.Button btnPartModify;
        private System.Windows.Forms.Button btnPartDelete;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductModify;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnExit;
    }
}

