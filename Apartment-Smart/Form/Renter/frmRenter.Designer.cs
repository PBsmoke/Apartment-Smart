namespace ApartmentSmart
{
    partial class frmRenter
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
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.cboTitleName = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCradID = new System.Windows.Forms.TextBox();
            this.lblCardID = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.cboTitleName);
            this.gbProduct.Controls.Add(this.lblAddress);
            this.gbProduct.Controls.Add(this.txtAddress);
            this.gbProduct.Controls.Add(this.txtTel);
            this.gbProduct.Controls.Add(this.lblTel);
            this.gbProduct.Controls.Add(this.txtCradID);
            this.gbProduct.Controls.Add(this.lblCardID);
            this.gbProduct.Controls.Add(this.txtNationality);
            this.gbProduct.Controls.Add(this.lblNationality);
            this.gbProduct.Controls.Add(this.txtRemark);
            this.gbProduct.Controls.Add(this.lblRemark);
            this.gbProduct.Controls.Add(this.txtLastname);
            this.gbProduct.Controls.Add(this.txtFirstname);
            this.gbProduct.Controls.Add(this.lblName);
            this.gbProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProduct.Location = new System.Drawing.Point(0, 39);
            this.gbProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Size = new System.Drawing.Size(635, 349);
            this.gbProduct.TabIndex = 10;
            this.gbProduct.TabStop = false;
            // 
            // cboTitleName
            // 
            this.cboTitleName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitleName.FormattingEnabled = true;
            this.cboTitleName.Items.AddRange(new object[] {
            "นาย",
            "นาง",
            "นางสาว"});
            this.cboTitleName.Location = new System.Drawing.Point(404, 127);
            this.cboTitleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTitleName.Name = "cboTitleName";
            this.cboTitleName.Size = new System.Drawing.Size(79, 24);
            this.cboTitleName.TabIndex = 165;
            this.cboTitleName.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 161);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(34, 17);
            this.lblAddress.TabIndex = 153;
            this.lblAddress.Text = "ที่อยู่";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(136, 158);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(480, 77);
            this.txtAddress.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(136, 127);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(252, 24);
            this.txtTel.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(14, 130);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(88, 17);
            this.lblTel.TabIndex = 38;
            this.lblTel.Text = "เบอร์โทรศัพท์";
            // 
            // txtCradID
            // 
            this.txtCradID.Location = new System.Drawing.Point(136, 63);
            this.txtCradID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCradID.Name = "txtCradID";
            this.txtCradID.Size = new System.Drawing.Size(252, 24);
            this.txtCradID.TabIndex = 2;
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(14, 66);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(110, 17);
            this.lblCardID.TabIndex = 36;
            this.lblCardID.Text = "เลขบัตรประชาชน";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(136, 95);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(252, 24);
            this.txtNationality.TabIndex = 3;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(14, 98);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(54, 17);
            this.lblNationality.TabIndex = 28;
            this.lblNationality.Text = "สัญชาติ";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(136, 244);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(480, 55);
            this.txtRemark.TabIndex = 6;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(14, 247);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(63, 17);
            this.lblRemark.TabIndex = 14;
            this.lblRemark.Text = "หมายเหตุ";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(498, 127);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(118, 24);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Visible = false;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(136, 31);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(480, 24);
            this.txtFirstname.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "ชื่อ";
            // 
            // frmRenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 353);
            this.ControlBox = false;
            this.Controls.Add(this.gbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmRenter";
            this.Text = "Renter";
            this.Controls.SetChildIndex(this.gbProduct, 0);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalofUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductUnitDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCradID;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboTitleName;
    }
}