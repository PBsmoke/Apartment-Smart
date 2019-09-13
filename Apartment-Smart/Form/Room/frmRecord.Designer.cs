namespace ApartmentSmart
{
    partial class frmRecord
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRecordDT = new System.Windows.Forms.DataGridView();
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPostPayment = new System.Windows.Forms.Button();
            this.apartmentDB1 = new ApartmentSmart.Data.ApartmentDB();
            this.uvrecorddetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordDT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContract_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colroom_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenterFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBefore_Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum_Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum_Water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvrecorddetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(393, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 127;
            this.btnSearch.Text = "แสดง";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRecordDT
            // 
            this.dgvRecordDT.AllowUserToAddRows = false;
            this.dgvRecordDT.AllowUserToDeleteRows = false;
            this.dgvRecordDT.AutoGenerateColumns = false;
            this.dgvRecordDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecordDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecord_ID,
            this.colYear,
            this.colMonth,
            this.colRecordStatus,
            this.colRecordDT_ID,
            this.colContract_ID,
            this.colRecord_water,
            this.colRecord_power,
            this.colRecord_date,
            this.colroom_price,
            this.colRenterFullname,
            this.colRoom_number,
            this.colBefore_Power,
            this.colNum_Power,
            this.colNum_Water});
            this.dgvRecordDT.DataSource = this.uvrecorddetailBindingSource;
            this.dgvRecordDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRecordDT.Location = new System.Drawing.Point(0, 113);
            this.dgvRecordDT.Name = "dgvRecordDT";
            this.dgvRecordDT.Size = new System.Drawing.Size(783, 169);
            this.dgvRecordDT.TabIndex = 126;
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 125;
            this.label2.Text = "เดือน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 124;
            this.label1.Text = "ปี";
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "มกราคม",
            "กุมภาพันธ์",
            "มีนาคม",
            "เมษายน",
            "พฤษภาคม",
            "มิถุนายน",
            "กรกฎาคม",
            "สิงหาคม",
            "กันยายน",
            "ตุลาคม",
            "พฤศจิกายน",
            "ธันวาคม"});
            this.cboMonth.Location = new System.Drawing.Point(220, 30);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 24);
            this.cboMonth.TabIndex = 123;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2562",
            "2563",
            "2564",
            "2565",
            "2566",
            "2567",
            "2568",
            "2569",
            "2570"});
            this.cboYear.Location = new System.Drawing.Point(37, 30);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 24);
            this.cboYear.TabIndex = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPostPayment);
            this.groupBox1.Controls.Add(this.cboYear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cboMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 74);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            // 
            // btnPostPayment
            // 
            this.btnPostPayment.Location = new System.Drawing.Point(486, 30);
            this.btnPostPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostPayment.Name = "btnPostPayment";
            this.btnPostPayment.Size = new System.Drawing.Size(291, 23);
            this.btnPostPayment.TabIndex = 128;
            this.btnPostPayment.Text = "บันทึกรายการชำระเงิน";
            this.btnPostPayment.UseVisualStyleBackColor = true;
            this.btnPostPayment.Click += new System.EventHandler(this.btnPostPayment_Click);
            // 
            // apartmentDB1
            // 
            this.apartmentDB1.DataSetName = "ApartmentDB";
            this.apartmentDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uvrecorddetailBindingSource
            // 
            this.uvrecorddetailBindingSource.DataMember = "uv_record_detail";
            this.uvrecorddetailBindingSource.DataSource = this.apartmentDB1;
            // 
            // colRecord_ID
            // 
            this.colRecord_ID.DataPropertyName = "Record_ID";
            this.colRecord_ID.HeaderText = "Record_ID";
            this.colRecord_ID.Name = "colRecord_ID";
            this.colRecord_ID.Visible = false;
            // 
            // colYear
            // 
            this.colYear.DataPropertyName = "Year";
            this.colYear.HeaderText = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = false;
            // 
            // colMonth
            // 
            this.colMonth.DataPropertyName = "Month";
            this.colMonth.HeaderText = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.Visible = false;
            // 
            // colRecordStatus
            // 
            this.colRecordStatus.DataPropertyName = "RecordStatus";
            this.colRecordStatus.HeaderText = "RecordStatus";
            this.colRecordStatus.Name = "colRecordStatus";
            this.colRecordStatus.Visible = false;
            // 
            // colRecordDT_ID
            // 
            this.colRecordDT_ID.DataPropertyName = "RecordDT_ID";
            this.colRecordDT_ID.HeaderText = "RecordDT_ID";
            this.colRecordDT_ID.Name = "colRecordDT_ID";
            this.colRecordDT_ID.Visible = false;
            // 
            // colContract_ID
            // 
            this.colContract_ID.DataPropertyName = "Contract_ID";
            this.colContract_ID.HeaderText = "Contract_ID";
            this.colContract_ID.Name = "colContract_ID";
            this.colContract_ID.Visible = false;
            // 
            // colRecord_water
            // 
            this.colRecord_water.DataPropertyName = "Record_water";
            this.colRecord_water.HeaderText = "Record_water";
            this.colRecord_water.Name = "colRecord_water";
            this.colRecord_water.Visible = false;
            // 
            // colRecord_power
            // 
            this.colRecord_power.DataPropertyName = "Record_power";
            this.colRecord_power.HeaderText = "Record_power";
            this.colRecord_power.Name = "colRecord_power";
            this.colRecord_power.Visible = false;
            // 
            // colRecord_date
            // 
            this.colRecord_date.DataPropertyName = "Record_date";
            this.colRecord_date.HeaderText = "Record_date";
            this.colRecord_date.Name = "colRecord_date";
            this.colRecord_date.Visible = false;
            // 
            // colroom_price
            // 
            this.colroom_price.DataPropertyName = "room_price";
            this.colroom_price.HeaderText = "room_price";
            this.colroom_price.Name = "colroom_price";
            this.colroom_price.Visible = false;
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
            // 
            // colBefore_Power
            // 
            this.colBefore_Power.DataPropertyName = "Before_Power";
            this.colBefore_Power.HeaderText = "หน่วยไฟฟ้าก่อนหน้า";
            this.colBefore_Power.Name = "colBefore_Power";
            // 
            // colNum_Power
            // 
            this.colNum_Power.DataPropertyName = "Num_Power";
            this.colNum_Power.HeaderText = "หน่วยไฟฟ้า";
            this.colNum_Power.Name = "colNum_Power";
            // 
            // colNum_Water
            // 
            this.colNum_Water.DataPropertyName = "Num_Water";
            this.colNum_Water.HeaderText = "น้ำปะปา";
            this.colNum_Water.Name = "colNum_Water";
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 298);
            this.ControlBox = false;
            this.Controls.Add(this.dgvRecordDT);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmRecord";
            this.Text = "Record";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvRecordDT, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvrecorddetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecordDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPostPayment;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.BindingSource uvrecorddetailBindingSource;
        private Data.ApartmentDB apartmentDB1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContract_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_water;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_power;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colroom_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenterFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBefore_Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum_Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum_Water;
    }
}