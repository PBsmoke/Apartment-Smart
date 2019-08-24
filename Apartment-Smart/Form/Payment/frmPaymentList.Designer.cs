namespace ApartmentSmart
{
    partial class frmPaymentList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.tblPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPay_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPay_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPay_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPay_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 56);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 125;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(707, 22);
            this.txtSearch.TabIndex = 124;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeight = 26;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPay_ID,
            this.colRenter_ID,
            this.colRecord_ID,
            this.colPay_date,
            this.colPay_amount,
            this.colPay_status,
            this.colUserID});
            this.dgvShow.DataSource = this.tblPaymentBindingSource;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(0, 95);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(812, 415);
            this.dgvShow.TabIndex = 124;
            this.dgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellClick);
            this.dgvShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellDoubleClick);
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPaymentBindingSource
            // 
            this.tblPaymentBindingSource.DataMember = "tblPayment";
            this.tblPaymentBindingSource.DataSource = this.apartmentDB;
            // 
            // colPay_ID
            // 
            this.colPay_ID.DataPropertyName = "Pay_ID";
            this.colPay_ID.HeaderText = "Pay_ID";
            this.colPay_ID.Name = "colPay_ID";
            this.colPay_ID.ReadOnly = true;
            this.colPay_ID.Visible = false;
            // 
            // colRenter_ID
            // 
            this.colRenter_ID.DataPropertyName = "Renter_ID";
            this.colRenter_ID.HeaderText = "ผู้เช่า";
            this.colRenter_ID.Name = "colRenter_ID";
            this.colRenter_ID.ReadOnly = true;
            // 
            // colRecord_ID
            // 
            this.colRecord_ID.DataPropertyName = "Record_ID";
            this.colRecord_ID.HeaderText = "Record_ID";
            this.colRecord_ID.Name = "colRecord_ID";
            this.colRecord_ID.ReadOnly = true;
            this.colRecord_ID.Visible = false;
            // 
            // colPay_date
            // 
            this.colPay_date.DataPropertyName = "Pay_date";
            this.colPay_date.HeaderText = "วันที่ชำระ";
            this.colPay_date.Name = "colPay_date";
            this.colPay_date.ReadOnly = true;
            // 
            // colPay_amount
            // 
            this.colPay_amount.DataPropertyName = "Pay_amount";
            this.colPay_amount.HeaderText = "ยอดชำระ";
            this.colPay_amount.Name = "colPay_amount";
            this.colPay_amount.ReadOnly = true;
            // 
            // colPay_status
            // 
            this.colPay_status.DataPropertyName = "Pay_status";
            this.colPay_status.HeaderText = "สถานะ";
            this.colPay_status.Name = "colPay_status";
            this.colPay_status.ReadOnly = true;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // frmPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(812, 510);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaymentList";
            this.Text = "รายการชำระ";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvShow, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.BindingSource tblPaymentBindingSource;
        private Data.ApartmentDB apartmentDB;
    }
}