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
            this.uvpaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.colPay_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenterFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colroom_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPay_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPay_Sum_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvpaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
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
            this.colContract_ID,
            this.colContract_No,
            this.colRoom_number,
            this.colRoom_floor,
            this.colRenterFullname,
            this.colroom_price,
            this.colContract_Type,
            this.colContract_TypeName,
            this.colDate_Checkin,
            this.colDate_Checkout,
            this.colPay_status,
            this.colPay_Sum_amount,
            this.colPaymentStatus});
            this.dgvShow.DataSource = this.uvpaymentBindingSource;
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
            // uvpaymentBindingSource
            // 
            this.uvpaymentBindingSource.DataMember = "uv_payment";
            this.uvpaymentBindingSource.DataSource = this.apartmentDB;
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colPay_ID
            // 
            this.colPay_ID.DataPropertyName = "Pay_ID";
            this.colPay_ID.HeaderText = "Pay_ID";
            this.colPay_ID.Name = "colPay_ID";
            this.colPay_ID.ReadOnly = true;
            this.colPay_ID.Visible = false;
            // 
            // colContract_ID
            // 
            this.colContract_ID.DataPropertyName = "Contract_ID";
            this.colContract_ID.HeaderText = "Contract_ID";
            this.colContract_ID.Name = "colContract_ID";
            this.colContract_ID.ReadOnly = true;
            this.colContract_ID.Visible = false;
            // 
            // colContract_No
            // 
            this.colContract_No.DataPropertyName = "Contract_No";
            this.colContract_No.HeaderText = "เลขที่สัญญา";
            this.colContract_No.Name = "colContract_No";
            this.colContract_No.ReadOnly = true;
            // 
            // colRoom_number
            // 
            this.colRoom_number.DataPropertyName = "Room_number";
            this.colRoom_number.HeaderText = "เลขที่ห้อง";
            this.colRoom_number.Name = "colRoom_number";
            this.colRoom_number.ReadOnly = true;
            // 
            // colRoom_floor
            // 
            this.colRoom_floor.DataPropertyName = "Room_floor";
            this.colRoom_floor.HeaderText = "ชั้น";
            this.colRoom_floor.Name = "colRoom_floor";
            this.colRoom_floor.ReadOnly = true;
            // 
            // colRenterFullname
            // 
            this.colRenterFullname.DataPropertyName = "RenterFullname";
            this.colRenterFullname.HeaderText = "ชื่อ - สกุล";
            this.colRenterFullname.Name = "colRenterFullname";
            this.colRenterFullname.ReadOnly = true;
            // 
            // colroom_price
            // 
            this.colroom_price.DataPropertyName = "room_price";
            this.colroom_price.HeaderText = "room_price";
            this.colroom_price.Name = "colroom_price";
            this.colroom_price.ReadOnly = true;
            this.colroom_price.Visible = false;
            // 
            // colContract_Type
            // 
            this.colContract_Type.DataPropertyName = "Contract_Type";
            this.colContract_Type.HeaderText = "Contract_Type";
            this.colContract_Type.Name = "colContract_Type";
            this.colContract_Type.ReadOnly = true;
            this.colContract_Type.Visible = false;
            // 
            // colContract_TypeName
            // 
            this.colContract_TypeName.DataPropertyName = "Contract_TypeName";
            this.colContract_TypeName.HeaderText = "ปรระเภทสัญญา";
            this.colContract_TypeName.Name = "colContract_TypeName";
            this.colContract_TypeName.ReadOnly = true;
            // 
            // colDate_Checkin
            // 
            this.colDate_Checkin.DataPropertyName = "Date_Checkin";
            this.colDate_Checkin.HeaderText = "Date_Checkin";
            this.colDate_Checkin.Name = "colDate_Checkin";
            this.colDate_Checkin.ReadOnly = true;
            this.colDate_Checkin.Visible = false;
            // 
            // colDate_Checkout
            // 
            this.colDate_Checkout.DataPropertyName = "Date_Checkout";
            this.colDate_Checkout.HeaderText = "Date_Checkout";
            this.colDate_Checkout.Name = "colDate_Checkout";
            this.colDate_Checkout.ReadOnly = true;
            this.colDate_Checkout.Visible = false;
            // 
            // colPay_status
            // 
            this.colPay_status.DataPropertyName = "Pay_status";
            this.colPay_status.HeaderText = "Pay_status";
            this.colPay_status.Name = "colPay_status";
            this.colPay_status.ReadOnly = true;
            this.colPay_status.Visible = false;
            // 
            // colPay_Sum_amount
            // 
            this.colPay_Sum_amount.DataPropertyName = "Pay_Sum_amount";
            this.colPay_Sum_amount.HeaderText = "Pay_Sum_amount";
            this.colPay_Sum_amount.Name = "colPay_Sum_amount";
            this.colPay_Sum_amount.ReadOnly = true;
            this.colPay_Sum_amount.Visible = false;
            // 
            // colPaymentStatus
            // 
            this.colPaymentStatus.DataPropertyName = "PaymentStatus";
            this.colPaymentStatus.HeaderText = "สถานะ";
            this.colPaymentStatus.Name = "colPaymentStatus";
            this.colPaymentStatus.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.uvpaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_amount;
        private System.Windows.Forms.BindingSource uvpaymentBindingSource;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenterFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colroom_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_Sum_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentStatus;
    }
}