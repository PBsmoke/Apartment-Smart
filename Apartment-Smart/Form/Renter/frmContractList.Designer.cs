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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.uvcontractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.colContract_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Recognizance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenterFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colroom_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvcontractBindingSource)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1001, 56);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(902, 20);
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
            this.txtSearch.Size = new System.Drawing.Size(896, 22);
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
            this.colContract_No,
            this.colContract_Date,
            this.colContract_Recognizance,
            this.colRenterFullname,
            this.colRoom_number,
            this.colContract_Status,
            this.colContract_Type,
            this.colContract_TypeName,
            this.colDate_Checkin,
            this.colroom_price,
            this.colRenter_ID,
            this.colRenter_Address,
            this.colRenter_Tel,
            this.colRoom_ID,
            this.colRoom_floor,
            this.colRoomType,
            this.colRoomStatus,
            this.colContract_StatusName});
            this.dgvShow.DataSource = this.uvcontractBindingSource;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.Location = new System.Drawing.Point(0, 95);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1001, 415);
            this.dgvShow.TabIndex = 124;
            this.dgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellClick);
            this.dgvShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellDoubleClick);
            // 
            // uvcontractBindingSource
            // 
            this.uvcontractBindingSource.DataMember = "uv_contract";
            this.uvcontractBindingSource.DataSource = this.apartmentDB;
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // colContract_Date
            // 
            this.colContract_Date.DataPropertyName = "Contract_Date";
            this.colContract_Date.HeaderText = "วันที่ทำสัญญา";
            this.colContract_Date.Name = "colContract_Date";
            this.colContract_Date.ReadOnly = true;
            // 
            // colContract_Recognizance
            // 
            this.colContract_Recognizance.DataPropertyName = "Contract_Recognizance";
            this.colContract_Recognizance.HeaderText = "Contract_Recognizance";
            this.colContract_Recognizance.Name = "colContract_Recognizance";
            this.colContract_Recognizance.ReadOnly = true;
            this.colContract_Recognizance.Visible = false;
            // 
            // colRenterFullname
            // 
            this.colRenterFullname.DataPropertyName = "RenterFullname";
            this.colRenterFullname.FillWeight = 150F;
            this.colRenterFullname.HeaderText = "ชื่อผู้เช่า";
            this.colRenterFullname.Name = "colRenterFullname";
            this.colRenterFullname.ReadOnly = true;
            // 
            // colRoom_number
            // 
            this.colRoom_number.DataPropertyName = "Room_number";
            this.colRoom_number.HeaderText = "เลขที่ห้อง";
            this.colRoom_number.Name = "colRoom_number";
            this.colRoom_number.ReadOnly = true;
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
            this.colContract_Type.Visible = false;
            // 
            // colContract_TypeName
            // 
            this.colContract_TypeName.DataPropertyName = "Contract_TypeName";
            this.colContract_TypeName.HeaderText = "ประเภทสัญญา";
            this.colContract_TypeName.Name = "colContract_TypeName";
            this.colContract_TypeName.ReadOnly = true;
            // 
            // colDate_Checkin
            // 
            this.colDate_Checkin.DataPropertyName = "Date_Checkin";
            this.colDate_Checkin.HeaderText = "วันที่เข้าพัก";
            this.colDate_Checkin.Name = "colDate_Checkin";
            this.colDate_Checkin.ReadOnly = true;
            // 
            // colroom_price
            // 
            this.colroom_price.DataPropertyName = "room_price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colroom_price.DefaultCellStyle = dataGridViewCellStyle1;
            this.colroom_price.HeaderText = "ราคาห้อง";
            this.colroom_price.Name = "colroom_price";
            this.colroom_price.ReadOnly = true;
            // 
            // colRenter_ID
            // 
            this.colRenter_ID.DataPropertyName = "Renter_ID";
            this.colRenter_ID.HeaderText = "Renter_ID";
            this.colRenter_ID.Name = "colRenter_ID";
            this.colRenter_ID.ReadOnly = true;
            this.colRenter_ID.Visible = false;
            // 
            // colRenter_Address
            // 
            this.colRenter_Address.DataPropertyName = "Renter_Address";
            this.colRenter_Address.HeaderText = "Renter_Address";
            this.colRenter_Address.Name = "colRenter_Address";
            this.colRenter_Address.ReadOnly = true;
            this.colRenter_Address.Visible = false;
            // 
            // colRenter_Tel
            // 
            this.colRenter_Tel.DataPropertyName = "Renter_Tel";
            this.colRenter_Tel.HeaderText = "Renter_Tel";
            this.colRenter_Tel.Name = "colRenter_Tel";
            this.colRenter_Tel.ReadOnly = true;
            this.colRenter_Tel.Visible = false;
            // 
            // colRoom_ID
            // 
            this.colRoom_ID.DataPropertyName = "Room_ID";
            this.colRoom_ID.HeaderText = "Room_ID";
            this.colRoom_ID.Name = "colRoom_ID";
            this.colRoom_ID.ReadOnly = true;
            this.colRoom_ID.Visible = false;
            // 
            // colRoom_floor
            // 
            this.colRoom_floor.DataPropertyName = "Room_floor";
            this.colRoom_floor.HeaderText = "Room_floor";
            this.colRoom_floor.Name = "colRoom_floor";
            this.colRoom_floor.ReadOnly = true;
            this.colRoom_floor.Visible = false;
            // 
            // colRoomType
            // 
            this.colRoomType.DataPropertyName = "RoomType";
            this.colRoomType.HeaderText = "RoomType";
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            this.colRoomType.Visible = false;
            // 
            // colRoomStatus
            // 
            this.colRoomStatus.DataPropertyName = "RoomStatus";
            this.colRoomStatus.HeaderText = "RoomStatus";
            this.colRoomStatus.Name = "colRoomStatus";
            this.colRoomStatus.ReadOnly = true;
            this.colRoomStatus.Visible = false;
            // 
            // colContract_StatusName
            // 
            this.colContract_StatusName.DataPropertyName = "Contract_StatusName";
            this.colContract_StatusName.HeaderText = "สถานะ";
            this.colContract_StatusName.Name = "colContract_StatusName";
            this.colContract_StatusName.ReadOnly = true;
            // 
            // frmContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1001, 510);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmContractList";
            this.Text = "ข้อมูลสัญญา";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvShow, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvcontractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.BindingSource uvcontractBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Recognizance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenterFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colroom_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_StatusName;
    }
}