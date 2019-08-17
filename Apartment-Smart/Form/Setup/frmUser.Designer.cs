namespace ApartmentSmart
{
    partial class frmUser
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPasswordconfirm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.txtFullName);
            this.gbUser.Controls.Add(this.lblEmployee);
            this.gbUser.Controls.Add(this.txtConPassword);
            this.gbUser.Controls.Add(this.txtPassword);
            this.gbUser.Controls.Add(this.txtUsername);
            this.gbUser.Controls.Add(this.lblPasswordconfirm);
            this.gbUser.Controls.Add(this.lblPassword);
            this.gbUser.Controls.Add(this.lblUsername);
            this.gbUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUser.Location = new System.Drawing.Point(0, 39);
            this.gbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUser.Size = new System.Drawing.Size(619, 165);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(170, 121);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(271, 24);
            this.txtFullName.TabIndex = 10;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(30, 125);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(25, 17);
            this.lblEmployee.TabIndex = 8;
            this.lblEmployee.Text = "ชื่อ";
            // 
            // txtConPassword
            // 
            this.txtConPassword.Location = new System.Drawing.Point(170, 89);
            this.txtConPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(271, 24);
            this.txtConPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 57);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 24);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 25);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 24);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPasswordconfirm
            // 
            this.lblPasswordconfirm.AutoSize = true;
            this.lblPasswordconfirm.Location = new System.Drawing.Point(30, 93);
            this.lblPasswordconfirm.Name = "lblPasswordconfirm";
            this.lblPasswordconfirm.Size = new System.Drawing.Size(91, 17);
            this.lblPasswordconfirm.TabIndex = 2;
            this.lblPasswordconfirm.Text = "ยืนยันรหัสผ่าน";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 61);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "รหัสผ่าน";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(56, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "รหัสผู้ใช้";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUsername,
            this.colUser_Name,
            this.userpasswordDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn});
            this.dgvUser.DataSource = this.tblUserBindingSource;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 204);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(619, 323);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.apartmentDB;
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // colUsername
            // 
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "รหัสผู้ใช้";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colUser_Name
            // 
            this.colUser_Name.DataPropertyName = "User_name";
            this.colUser_Name.HeaderText = "ชื่อ";
            this.colUser_Name.Name = "colUser_Name";
            this.colUser_Name.ReadOnly = true;
            // 
            // userpasswordDataGridViewTextBoxColumn
            // 
            this.userpasswordDataGridViewTextBoxColumn.DataPropertyName = "User_password";
            this.userpasswordDataGridViewTextBoxColumn.HeaderText = "User_password";
            this.userpasswordDataGridViewTextBoxColumn.Name = "userpasswordDataGridViewTextBoxColumn";
            this.userpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.userpasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "User_type";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "User_type";
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            this.usertypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.usertypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 527);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.gbUser);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmUser";
            this.Text = "User";
            this.Controls.SetChildIndex(this.gbUser, 0);
            this.Controls.SetChildIndex(this.dgvUser, 0);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPasswordconfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
    }
}