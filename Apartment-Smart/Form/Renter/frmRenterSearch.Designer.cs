namespace ApartmentSmart
{
    partial class frmRenterSearch
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
            this.gbProductSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProductSearch = new System.Windows.Forms.DataGridView();
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.tblRenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.gbProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductSearch
            // 
            this.gbProductSearch.Controls.Add(this.btnSearch);
            this.gbProductSearch.Controls.Add(this.txtSearch);
            this.gbProductSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProductSearch.Location = new System.Drawing.Point(0, 0);
            this.gbProductSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProductSearch.Name = "gbProductSearch";
            this.gbProductSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProductSearch.Size = new System.Drawing.Size(903, 54);
            this.gbProductSearch.TabIndex = 0;
            this.gbProductSearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(804, 19);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(786, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvProductSearch
            // 
            this.dgvProductSearch.AllowUserToAddRows = false;
            this.dgvProductSearch.AllowUserToDeleteRows = false;
            this.dgvProductSearch.AllowUserToResizeColumns = false;
            this.dgvProductSearch.AllowUserToResizeRows = false;
            this.dgvProductSearch.AutoGenerateColumns = false;
            this.dgvProductSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductSearch.ColumnHeadersHeight = 26;
            this.dgvProductSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvProductSearch.DataSource = this.tblRenterBindingSource;
            this.dgvProductSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductSearch.Location = new System.Drawing.Point(0, 54);
            this.dgvProductSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductSearch.Name = "dgvProductSearch";
            this.dgvProductSearch.ReadOnly = true;
            this.dgvProductSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductSearch.Size = new System.Drawing.Size(903, 360);
            this.dgvProductSearch.TabIndex = 2;
            this.dgvProductSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductSearch_CellDoubleClick);
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRenterBindingSource
            // 
            this.tblRenterBindingSource.DataMember = "tblRenter";
            this.tblRenterBindingSource.DataSource = this.apartmentDB;
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
            // frmRenterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 414);
            this.Controls.Add(this.dgvProductSearch);
            this.Controls.Add(this.gbProductSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRenterSearch";
            this.Text = "ค้นหาสินค้า";
            this.Load += new System.EventHandler(this.frmRenterSearch_Load);
            this.gbProductSearch.ResumeLayout(false);
            this.gbProductSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRenterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductSearch;
        private System.Windows.Forms.DataGridView dgvProductSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
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