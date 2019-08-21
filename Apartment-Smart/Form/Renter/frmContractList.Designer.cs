namespace ApartmentSmart
{
    partial class frmContractList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.tblContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colContract_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Recognizance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPower_first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWater_first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContractBindingSource)).BeginInit();
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
            this.colContract_ID,
            this.colRenter_ID,
            this.colRoom_ID,
            this.colContract_No,
            this.colContract_Date,
            this.colContract_Recognizance,
            this.colContract_Status,
            this.colContract_Type,
            this.colDate_Checkin,
            this.colDate_Checkout,
            this.colPower_first,
            this.colWater_first,
            this.colRoom_price,
            this.colRemark});
            this.dgvShow.DataSource = this.tblContractBindingSource;
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
            // tblContractBindingSource
            // 
            this.tblContractBindingSource.DataMember = "tblContract";
            this.tblContractBindingSource.DataSource = this.apartmentDB;
            // 
            // colContract_ID
            // 
            this.colContract_ID.DataPropertyName = "Contract_ID";
            this.colContract_ID.HeaderText = "Contract_ID";
            this.colContract_ID.Name = "colContract_ID";
            this.colContract_ID.ReadOnly = true;
            this.colContract_ID.Visible = false;
            // 
            // colRenter_ID
            // 
            this.colRenter_ID.DataPropertyName = "Renter_ID";
            this.colRenter_ID.HeaderText = "Renter_ID";
            this.colRenter_ID.Name = "colRenter_ID";
            this.colRenter_ID.ReadOnly = true;
            this.colRenter_ID.Visible = false;
            // 
            // colRoom_ID
            // 
            this.colRoom_ID.DataPropertyName = "Room_ID";
            this.colRoom_ID.HeaderText = "Room_ID";
            this.colRoom_ID.Name = "colRoom_ID";
            this.colRoom_ID.ReadOnly = true;
            this.colRoom_ID.Visible = false;
            // 
            // colContract_No
            // 
            this.colContract_No.DataPropertyName = "Contract_No";
            this.colContract_No.HeaderText = "Contract_No";
            this.colContract_No.Name = "colContract_No";
            this.colContract_No.ReadOnly = true;
            // 
            // colContract_Date
            // 
            this.colContract_Date.DataPropertyName = "Contract_Date";
            this.colContract_Date.HeaderText = "Contract_Date";
            this.colContract_Date.Name = "colContract_Date";
            this.colContract_Date.ReadOnly = true;
            // 
            // colContract_Recognizance
            // 
            this.colContract_Recognizance.DataPropertyName = "Contract_Recognizance";
            this.colContract_Recognizance.HeaderText = "Contract_Recognizance";
            this.colContract_Recognizance.Name = "colContract_Recognizance";
            this.colContract_Recognizance.ReadOnly = true;
            // 
            // colContract_Status
            // 
            this.colContract_Status.DataPropertyName = "Contract_Status";
            this.colContract_Status.HeaderText = "Contract_Status";
            this.colContract_Status.Name = "colContract_Status";
            this.colContract_Status.ReadOnly = true;
            this.colContract_Status.Visible = false;
            // 
            // colContract_Type
            // 
            this.colContract_Type.DataPropertyName = "Contract_Type";
            this.colContract_Type.HeaderText = "Contract_Type";
            this.colContract_Type.Name = "colContract_Type";
            this.colContract_Type.ReadOnly = true;
            // 
            // colDate_Checkin
            // 
            this.colDate_Checkin.DataPropertyName = "Date_Checkin";
            this.colDate_Checkin.HeaderText = "Date_Checkin";
            this.colDate_Checkin.Name = "colDate_Checkin";
            this.colDate_Checkin.ReadOnly = true;
            // 
            // colDate_Checkout
            // 
            this.colDate_Checkout.DataPropertyName = "Date_Checkout";
            this.colDate_Checkout.HeaderText = "Date_Checkout";
            this.colDate_Checkout.Name = "colDate_Checkout";
            this.colDate_Checkout.ReadOnly = true;
            // 
            // colPower_first
            // 
            this.colPower_first.DataPropertyName = "power_first";
            this.colPower_first.HeaderText = "power_first";
            this.colPower_first.Name = "colPower_first";
            this.colPower_first.ReadOnly = true;
            this.colPower_first.Visible = false;
            // 
            // colWater_first
            // 
            this.colWater_first.DataPropertyName = "water_first";
            this.colWater_first.HeaderText = "water_first";
            this.colWater_first.Name = "colWater_first";
            this.colWater_first.ReadOnly = true;
            this.colWater_first.Visible = false;
            // 
            // colRoom_price
            // 
            this.colRoom_price.DataPropertyName = "room_price";
            this.colRoom_price.HeaderText = "room_price";
            this.colRoom_price.Name = "colRoom_price";
            this.colRoom_price.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Visible = false;
            // 
            // frmContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(812, 510);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmContractList";
            this.Text = "ข้อมูลสัญยา";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvShow, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContractBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource tblContractBindingSource;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Recognizance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPower_first;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWater_first;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}