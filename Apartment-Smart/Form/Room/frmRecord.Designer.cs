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
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.tblRecordDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recordDTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numWaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordwaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordpowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recorddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
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
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordDTIDDataGridViewTextBoxColumn,
            this.recordIDDataGridViewTextBoxColumn,
            this.renterIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.numWaterDataGridViewTextBoxColumn,
            this.numPowerDataGridViewTextBoxColumn,
            this.recordwaterDataGridViewTextBoxColumn,
            this.recordpowerDataGridViewTextBoxColumn,
            this.recorddateDataGridViewTextBoxColumn});
            this.dgvShow.DataSource = this.tblRecordDTBindingSource;
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvShow.Location = new System.Drawing.Point(0, 113);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(783, 169);
            this.dgvShow.TabIndex = 126;
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
            // recordDTIDDataGridViewTextBoxColumn
            // 
            this.recordDTIDDataGridViewTextBoxColumn.DataPropertyName = "RecordDT_ID";
            this.recordDTIDDataGridViewTextBoxColumn.HeaderText = "RecordDT_ID";
            this.recordDTIDDataGridViewTextBoxColumn.Name = "recordDTIDDataGridViewTextBoxColumn";
            this.recordDTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "Record_ID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "Record_ID";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // renterIDDataGridViewTextBoxColumn
            // 
            this.renterIDDataGridViewTextBoxColumn.DataPropertyName = "Renter_ID";
            this.renterIDDataGridViewTextBoxColumn.FillWeight = 200F;
            this.renterIDDataGridViewTextBoxColumn.HeaderText = "Renter_ID";
            this.renterIDDataGridViewTextBoxColumn.Name = "renterIDDataGridViewTextBoxColumn";
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            // 
            // numWaterDataGridViewTextBoxColumn
            // 
            this.numWaterDataGridViewTextBoxColumn.DataPropertyName = "Num_Water";
            this.numWaterDataGridViewTextBoxColumn.HeaderText = "Num_Water";
            this.numWaterDataGridViewTextBoxColumn.Name = "numWaterDataGridViewTextBoxColumn";
            // 
            // numPowerDataGridViewTextBoxColumn
            // 
            this.numPowerDataGridViewTextBoxColumn.DataPropertyName = "Num_Power";
            this.numPowerDataGridViewTextBoxColumn.HeaderText = "Num_Power";
            this.numPowerDataGridViewTextBoxColumn.Name = "numPowerDataGridViewTextBoxColumn";
            // 
            // recordwaterDataGridViewTextBoxColumn
            // 
            this.recordwaterDataGridViewTextBoxColumn.DataPropertyName = "Record_water";
            this.recordwaterDataGridViewTextBoxColumn.HeaderText = "Record_water";
            this.recordwaterDataGridViewTextBoxColumn.Name = "recordwaterDataGridViewTextBoxColumn";
            this.recordwaterDataGridViewTextBoxColumn.Visible = false;
            // 
            // recordpowerDataGridViewTextBoxColumn
            // 
            this.recordpowerDataGridViewTextBoxColumn.DataPropertyName = "Record_power";
            this.recordpowerDataGridViewTextBoxColumn.HeaderText = "Record_power";
            this.recordpowerDataGridViewTextBoxColumn.Name = "recordpowerDataGridViewTextBoxColumn";
            this.recordpowerDataGridViewTextBoxColumn.Visible = false;
            // 
            // recorddateDataGridViewTextBoxColumn
            // 
            this.recorddateDataGridViewTextBoxColumn.DataPropertyName = "Record_date";
            this.recorddateDataGridViewTextBoxColumn.HeaderText = "Record_date";
            this.recorddateDataGridViewTextBoxColumn.Name = "recorddateDataGridViewTextBoxColumn";
            this.recorddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 298);
            this.ControlBox = false;
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmRecord";
            this.Text = "Record";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvShow, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecordDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum_Water;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum_Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_water;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_power;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_date;
        private System.Windows.Forms.BindingSource tblRecordDTBindingSource;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numWaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordwaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordpowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recorddateDataGridViewTextBoxColumn;
    }
}