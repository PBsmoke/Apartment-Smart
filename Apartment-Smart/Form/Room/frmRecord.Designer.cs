﻿namespace ApartmentSmart
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
            this.tblRecordDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPostPayment = new System.Windows.Forms.Button();
            this.colRecordDT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum_Water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNum_Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecord_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecordDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.colRecordDT_ID,
            this.colRecord_ID,
            this.colRenter_Name,
            this.colRoom_ID,
            this.colRoom_Number,
            this.colNum_Water,
            this.colNum_Power,
            this.colRecord_water,
            this.colRecord_power,
            this.colRecord_date});
            this.dgvRecordDT.DataSource = this.tblRecordDTBindingSource;
            this.dgvRecordDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRecordDT.Location = new System.Drawing.Point(0, 113);
            this.dgvRecordDT.Name = "dgvRecordDT";
            this.dgvRecordDT.Size = new System.Drawing.Size(783, 169);
            this.dgvRecordDT.TabIndex = 126;
            // 
            // tblRecordDTBindingSource
            // 
            this.tblRecordDTBindingSource.DataMember = "tblRecordDT";
            this.tblRecordDTBindingSource.DataSource = this.apartmentDB;
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
            "2561",
            "2561",
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
            // colRecordDT_ID
            // 
            this.colRecordDT_ID.DataPropertyName = "RecordDT_ID";
            this.colRecordDT_ID.HeaderText = "RecordDT_ID";
            this.colRecordDT_ID.Name = "colRecordDT_ID";
            this.colRecordDT_ID.ReadOnly = true;
            this.colRecordDT_ID.Visible = false;
            // 
            // colRecord_ID
            // 
            this.colRecord_ID.DataPropertyName = "Record_ID";
            this.colRecord_ID.HeaderText = "Record_ID";
            this.colRecord_ID.Name = "colRecord_ID";
            this.colRecord_ID.ReadOnly = true;
            this.colRecord_ID.Visible = false;
            // 
            // colRenter_Name
            // 
            this.colRenter_Name.DataPropertyName = "Renter_Name";
            this.colRenter_Name.HeaderText = "ชื่อผู้เช่า";
            this.colRenter_Name.Name = "colRenter_Name";
            this.colRenter_Name.ReadOnly = true;
            // 
            // colRoom_ID
            // 
            this.colRoom_ID.DataPropertyName = "Room_ID";
            this.colRoom_ID.HeaderText = "Room_ID";
            this.colRoom_ID.Name = "colRoom_ID";
            this.colRoom_ID.ReadOnly = true;
            this.colRoom_ID.Visible = false;
            // 
            // colRoom_Number
            // 
            this.colRoom_Number.DataPropertyName = "Room_Number";
            this.colRoom_Number.HeaderText = "เลขที่ห้องพัก";
            this.colRoom_Number.Name = "colRoom_Number";
            this.colRoom_Number.ReadOnly = true;
            // 
            // colNum_Water
            // 
            this.colNum_Water.DataPropertyName = "Num_Water";
            this.colNum_Water.HeaderText = "ค่าน้ำปะปา";
            this.colNum_Water.Name = "colNum_Water";
            // 
            // colNum_Power
            // 
            this.colNum_Power.DataPropertyName = "Num_Power";
            this.colNum_Power.HeaderText = "ค่าไฟฟ้า";
            this.colNum_Power.Name = "colNum_Power";
            // 
            // colRecord_water
            // 
            this.colRecord_water.DataPropertyName = "Record_water";
            this.colRecord_water.HeaderText = "Record_water";
            this.colRecord_water.Name = "colRecord_water";
            this.colRecord_water.ReadOnly = true;
            this.colRecord_water.Visible = false;
            // 
            // colRecord_power
            // 
            this.colRecord_power.DataPropertyName = "Record_power";
            this.colRecord_power.HeaderText = "Record_power";
            this.colRecord_power.Name = "colRecord_power";
            this.colRecord_power.ReadOnly = true;
            this.colRecord_power.Visible = false;
            // 
            // colRecord_date
            // 
            this.colRecord_date.DataPropertyName = "Record_date";
            this.colRecord_date.HeaderText = "Record_date";
            this.colRecord_date.Name = "colRecord_date";
            this.colRecord_date.ReadOnly = true;
            this.colRecord_date.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.tblRecordDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.BindingSource tblRecordDTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPostPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum_Water;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum_Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_water;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_power;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_date;
    }
}