namespace ApartmentSmart
{
    partial class frmRenterList
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
            this.colRenter_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_TitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenter_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRenterBindingSource)).BeginInit();
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
            this.colRenter_ID,
            this.colRenter_TitleName,
            this.colRenter_Name,
            this.colRenter_Lastname,
            this.colRenter_Nationality,
            this.colRenter_Card,
            this.colRenter_Address,
            this.colRenter_Tel,
            this.colRenter_Status,
            this.colRenter_Remark});
            this.dgvShow.DataSource = this.tblRenterBindingSource;
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
            // colRenter_ID
            // 
            this.colRenter_ID.DataPropertyName = "Renter_ID";
            this.colRenter_ID.HeaderText = "Renter_ID";
            this.colRenter_ID.Name = "colRenter_ID";
            this.colRenter_ID.ReadOnly = true;
            this.colRenter_ID.Visible = false;
            // 
            // colRenter_TitleName
            // 
            this.colRenter_TitleName.DataPropertyName = "Renter_TitleName";
            this.colRenter_TitleName.HeaderText = "คำนำหน้าชื่อ";
            this.colRenter_TitleName.Name = "colRenter_TitleName";
            this.colRenter_TitleName.ReadOnly = true;
            // 
            // colRenter_Name
            // 
            this.colRenter_Name.DataPropertyName = "Renter_Name";
            this.colRenter_Name.HeaderText = "ชื่อ";
            this.colRenter_Name.Name = "colRenter_Name";
            this.colRenter_Name.ReadOnly = true;
            // 
            // colRenter_Lastname
            // 
            this.colRenter_Lastname.DataPropertyName = "Renter_Lastname";
            this.colRenter_Lastname.HeaderText = "นามสกุล";
            this.colRenter_Lastname.Name = "colRenter_Lastname";
            this.colRenter_Lastname.ReadOnly = true;
            // 
            // colRenter_Nationality
            // 
            this.colRenter_Nationality.DataPropertyName = "Renter_Nationality";
            this.colRenter_Nationality.HeaderText = "Renter_Nationality";
            this.colRenter_Nationality.Name = "colRenter_Nationality";
            this.colRenter_Nationality.ReadOnly = true;
            this.colRenter_Nationality.Visible = false;
            // 
            // colRenter_Card
            // 
            this.colRenter_Card.DataPropertyName = "Renter_Card";
            this.colRenter_Card.HeaderText = "Renter_Card";
            this.colRenter_Card.Name = "colRenter_Card";
            this.colRenter_Card.ReadOnly = true;
            this.colRenter_Card.Visible = false;
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
            this.colRenter_Tel.HeaderText = "เบอร์โทรศัพท์";
            this.colRenter_Tel.Name = "colRenter_Tel";
            this.colRenter_Tel.ReadOnly = true;
            // 
            // colRenter_Status
            // 
            this.colRenter_Status.DataPropertyName = "Renter_Status";
            this.colRenter_Status.HeaderText = "Renter_Status";
            this.colRenter_Status.Name = "colRenter_Status";
            this.colRenter_Status.ReadOnly = true;
            this.colRenter_Status.Visible = false;
            // 
            // colRenter_Remark
            // 
            this.colRenter_Remark.DataPropertyName = "Renter_Remark";
            this.colRenter_Remark.HeaderText = "Renter_Remark";
            this.colRenter_Remark.Name = "colRenter_Remark";
            this.colRenter_Remark.ReadOnly = true;
            this.colRenter_Remark.Visible = false;
            // 
            // tblRenterBindingSource
            // 
            this.tblRenterBindingSource.DataMember = "tblRenter";
            this.tblRenterBindingSource.DataSource = this.apartmentDB;
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmRenterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(812, 510);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmRenterList";
            this.Text = "ข้อมูลผู้เช่า";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvShow, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRenterBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource tblRenterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_TitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenter_Remark;
    }
}