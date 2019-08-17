namespace ApartmentSmart
{
    partial class frmRoomList
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
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colRoom_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Price_daily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Price_monthly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_MetersNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
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
            this.colRoom_ID,
            this.colRoom_number,
            this.colRoom_floor,
            this.colRoom_Type,
            this.colRoom_Price_daily,
            this.colRoom_Price_monthly,
            this.colRoom_status,
            this.colRoom_MetersNo,
            this.colRoom_Remark});
            this.dgvShow.DataSource = this.tblRoomBindingSource;
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
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tblRoom";
            this.tblRoomBindingSource.DataSource = this.apartmentDB;
            // 
            // colRoom_ID
            // 
            this.colRoom_ID.DataPropertyName = "Room_ID";
            this.colRoom_ID.HeaderText = "Room_ID";
            this.colRoom_ID.Name = "colRoom_ID";
            this.colRoom_ID.ReadOnly = true;
            this.colRoom_ID.Visible = false;
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
            // colRoom_Type
            // 
            this.colRoom_Type.DataPropertyName = "Room_Type";
            this.colRoom_Type.HeaderText = "ประเภทห้อง";
            this.colRoom_Type.Name = "colRoom_Type";
            this.colRoom_Type.ReadOnly = true;
            // 
            // colRoom_Price_daily
            // 
            this.colRoom_Price_daily.DataPropertyName = "Room_Price_daily";
            this.colRoom_Price_daily.HeaderText = "ราคารายวัน";
            this.colRoom_Price_daily.Name = "colRoom_Price_daily";
            this.colRoom_Price_daily.ReadOnly = true;
            // 
            // colRoom_Price_monthly
            // 
            this.colRoom_Price_monthly.DataPropertyName = "Room_Price_monthly";
            this.colRoom_Price_monthly.HeaderText = "ราคารายเดือน";
            this.colRoom_Price_monthly.Name = "colRoom_Price_monthly";
            this.colRoom_Price_monthly.ReadOnly = true;
            // 
            // colRoom_status
            // 
            this.colRoom_status.DataPropertyName = "Room_status";
            this.colRoom_status.HeaderText = "สถานะ";
            this.colRoom_status.Name = "colRoom_status";
            this.colRoom_status.ReadOnly = true;
            // 
            // colRoom_MetersNo
            // 
            this.colRoom_MetersNo.DataPropertyName = "Room_MetersNo";
            this.colRoom_MetersNo.HeaderText = "Room_MetersNo";
            this.colRoom_MetersNo.Name = "colRoom_MetersNo";
            this.colRoom_MetersNo.ReadOnly = true;
            this.colRoom_MetersNo.Visible = false;
            // 
            // colRoom_Remark
            // 
            this.colRoom_Remark.DataPropertyName = "Room_Remark";
            this.colRoom_Remark.HeaderText = "Room_Remark";
            this.colRoom_Remark.Name = "colRoom_Remark";
            this.colRoom_Remark.ReadOnly = true;
            this.colRoom_Remark.Visible = false;
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(812, 510);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmProductList";
            this.Text = "ข้อมูลสินค้า";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvShow, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Price_daily;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Price_monthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_MetersNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Remark;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private Data.ApartmentDB apartmentDB;
    }
}