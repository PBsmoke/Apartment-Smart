namespace ApartmentSmart
{
    partial class frmRecordList
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
            this.uvrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvrecordBindingSource)).BeginInit();
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
            this.colRecord_ID,
            this.colYear,
            this.colMonth,
            this.colRecordStatus,
            this.colStatusID,
            this.colName,
            this.colStatusType});
            this.dgvShow.DataSource = this.uvrecordBindingSource;
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
            // uvrecordBindingSource
            // 
            this.uvrecordBindingSource.DataMember = "uv_record";
            this.uvrecordBindingSource.DataSource = this.apartmentDB;
            // 
            // colRecord_ID
            // 
            this.colRecord_ID.DataPropertyName = "Record_ID";
            this.colRecord_ID.HeaderText = "Record_ID";
            this.colRecord_ID.Name = "colRecord_ID";
            this.colRecord_ID.ReadOnly = true;
            this.colRecord_ID.Visible = false;
            // 
            // colYear
            // 
            this.colYear.DataPropertyName = "Year";
            this.colYear.HeaderText = "ปี";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colMonth
            // 
            this.colMonth.DataPropertyName = "Month";
            this.colMonth.HeaderText = "เดือน";
            this.colMonth.Name = "colMonth";
            this.colMonth.ReadOnly = true;
            // 
            // colRecordStatus
            // 
            this.colRecordStatus.DataPropertyName = "RecordStatus";
            this.colRecordStatus.HeaderText = "RecordStatus";
            this.colRecordStatus.Name = "colRecordStatus";
            this.colRecordStatus.ReadOnly = true;
            this.colRecordStatus.Visible = false;
            // 
            // colStatusID
            // 
            this.colStatusID.DataPropertyName = "StatusID";
            this.colStatusID.HeaderText = "StatusID";
            this.colStatusID.Name = "colStatusID";
            this.colStatusID.ReadOnly = true;
            this.colStatusID.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "สถานะ";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colStatusType
            // 
            this.colStatusType.DataPropertyName = "StatusType";
            this.colStatusType.HeaderText = "StatusType";
            this.colStatusType.Name = "colStatusType";
            this.colStatusType.ReadOnly = true;
            this.colStatusType.Visible = false;
            // 
            // frmRecordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(812, 510);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmRecordList";
            this.Text = "รายการบันทึกค่าน้ำค่าไฟ";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvShow, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvrecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatusType;
        private System.Windows.Forms.BindingSource uvrecordBindingSource;
        private Data.ApartmentDB apartmentDB;
    }
}