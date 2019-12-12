namespace Product_Return
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Found = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Packed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lblRowsCount = new System.Windows.Forms.Label();
            this.btnManageBrands = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChkSerStat = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(145, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(279, 32);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(430, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Found,
            this.Packed,
            this.InvoiceID,
            this.Brand,
            this.pid,
            this.shortCode,
            this.Color,
            this.pSize,
            this.Quantity,
            this.Price,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 355);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // Found
            // 
            this.Found.HeaderText = "Found";
            this.Found.Name = "Found";
            this.Found.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Found.Width = 70;
            // 
            // Packed
            // 
            this.Packed.HeaderText = "Packed";
            this.Packed.Name = "Packed";
            this.Packed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Packed.Width = 70;
            // 
            // InvoiceID
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceID.DefaultCellStyle = dataGridViewCellStyle28;
            this.InvoiceID.HeaderText = "Invoice ID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            this.InvoiceID.Width = 120;
            // 
            // Brand
            // 
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 12F);
            this.Brand.DefaultCellStyle = dataGridViewCellStyle29;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // pid
            // 
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 12F);
            this.pid.DefaultCellStyle = dataGridViewCellStyle30;
            this.pid.HeaderText = "Product Code";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Width = 180;
            // 
            // shortCode
            // 
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Arial", 12F);
            this.shortCode.DefaultCellStyle = dataGridViewCellStyle31;
            this.shortCode.HeaderText = "Short Code";
            this.shortCode.Name = "shortCode";
            this.shortCode.ReadOnly = true;
            this.shortCode.Width = 120;
            // 
            // Color
            // 
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Arial", 12F);
            this.Color.DefaultCellStyle = dataGridViewCellStyle32;
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // pSize
            // 
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Arial", 12F);
            this.pSize.DefaultCellStyle = dataGridViewCellStyle33;
            this.pSize.HeaderText = "Size";
            this.pSize.Name = "pSize";
            this.pSize.ReadOnly = true;
            // 
            // Quantity
            // 
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Arial", 12F);
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle34;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Arial", 12F);
            this.Price.DefaultCellStyle = dataGridViewCellStyle35;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Arial", 12F);
            this.Edit.DefaultCellStyle = dataGridViewCellStyle36;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(574, 7);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(144, 32);
            this.btnAddRecord.TabIndex = 4;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCriteria.Font = new System.Drawing.Font("Arial", 10.75F);
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "Product Code",
            "Invoice ID"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(12, 18);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(127, 24);
            this.cmbSearchCriteria.TabIndex = 1;
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.AutoSize = true;
            this.lblRowsCount.Location = new System.Drawing.Point(12, 51);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(198, 24);
            this.lblRowsCount.TabIndex = 6;
            this.lblRowsCount.Text = "Showing 0 record(s)";
            // 
            // btnManageBrands
            // 
            this.btnManageBrands.Font = new System.Drawing.Font("Arial", 12.75F);
            this.btnManageBrands.Location = new System.Drawing.Point(574, 43);
            this.btnManageBrands.Name = "btnManageBrands";
            this.btnManageBrands.Size = new System.Drawing.Size(144, 32);
            this.btnManageBrands.TabIndex = 5;
            this.btnManageBrands.Text = "Manage Brands";
            this.btnManageBrands.UseVisualStyleBackColor = true;
            this.btnManageBrands.Click += new System.EventHandler(this.btnManageBrands_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.75F);
            this.label1.Location = new System.Drawing.Point(442, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Press delete button on keyboard to delete";
            // 
            // btnChkSerStat
            // 
            this.btnChkSerStat.Font = new System.Drawing.Font("Arial", 10.75F);
            this.btnChkSerStat.Location = new System.Drawing.Point(12, 438);
            this.btnChkSerStat.Name = "btnChkSerStat";
            this.btnChkSerStat.Size = new System.Drawing.Size(71, 27);
            this.btnChkSerStat.TabIndex = 9;
            this.btnChkSerStat.Text = "Update";
            this.btnChkSerStat.UseVisualStyleBackColor = true;
            this.btnChkSerStat.Click += new System.EventHandler(this.btnChkSerStat_Click);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Arial", 12.75F);
            this.lblServerStatus.Location = new System.Drawing.Point(85, 442);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(115, 19);
            this.lblServerStatus.TabIndex = 10;
            this.lblServerStatus.Text = "[server_status]";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 469);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.btnChkSerStat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageBrands);
            this.Controls.Add(this.lblRowsCount);
            this.Controls.Add(this.cmbSearchCriteria);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Font = new System.Drawing.Font("Arial", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.Label lblRowsCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Found;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Packed;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button btnManageBrands;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnChkSerStat;
        private System.Windows.Forms.Label lblServerStatus;
    }
}