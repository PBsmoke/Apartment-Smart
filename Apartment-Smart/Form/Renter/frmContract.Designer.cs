namespace ApartmentSmart
{
    partial class frmContract
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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnAddRenter = new System.Windows.Forms.Button();
            this.cboContractType = new System.Windows.Forms.ComboBox();
            this.dtpcheckout = new System.Windows.Forms.DateTimePicker();
            this.lblcheckout = new System.Windows.Forms.Label();
            this.dtpcheckin = new System.Windows.Forms.DateTimePicker();
            this.lblcheckin = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.lblContractType = new System.Windows.Forms.Label();
            this.txtRecognizance = new System.Windows.Forms.TextBox();
            this.lblRecognizance = new System.Windows.Forms.Label();
            this.lblContractDate = new System.Windows.Forms.Label();
            this.txtRenterName = new System.Windows.Forms.TextBox();
            this.lblRenter = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.textBox2);
            this.gbProduct.Controls.Add(this.txtRoomType);
            this.gbProduct.Controls.Add(this.btnAddRoom);
            this.gbProduct.Controls.Add(this.btnAddRenter);
            this.gbProduct.Controls.Add(this.cboContractType);
            this.gbProduct.Controls.Add(this.dtpcheckout);
            this.gbProduct.Controls.Add(this.lblcheckout);
            this.gbProduct.Controls.Add(this.dtpcheckin);
            this.gbProduct.Controls.Add(this.lblcheckin);
            this.gbProduct.Controls.Add(this.txtRoom);
            this.gbProduct.Controls.Add(this.lblRoom);
            this.gbProduct.Controls.Add(this.dtpContractDate);
            this.gbProduct.Controls.Add(this.lblContractType);
            this.gbProduct.Controls.Add(this.txtRecognizance);
            this.gbProduct.Controls.Add(this.lblRecognizance);
            this.gbProduct.Controls.Add(this.lblContractDate);
            this.gbProduct.Controls.Add(this.txtRenterName);
            this.gbProduct.Controls.Add(this.lblRenter);
            this.gbProduct.Controls.Add(this.txtRemark);
            this.gbProduct.Controls.Add(this.lblRemark);
            this.gbProduct.Controls.Add(this.txtContractNo);
            this.gbProduct.Controls.Add(this.lblContractNo);
            this.gbProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProduct.Location = new System.Drawing.Point(0, 39);
            this.gbProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Size = new System.Drawing.Size(636, 321);
            this.gbProduct.TabIndex = 10;
            this.gbProduct.TabStop = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Image = global::ApartmentSmart.Properties.Resources.icons8_search_64;
            this.btnAddRoom.Location = new System.Drawing.Point(429, 127);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(24, 24);
            this.btnAddRoom.TabIndex = 175;
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnAddRenter
            // 
            this.btnAddRenter.Image = global::ApartmentSmart.Properties.Resources.icons8_search_64;
            this.btnAddRenter.Location = new System.Drawing.Point(429, 98);
            this.btnAddRenter.Name = "btnAddRenter";
            this.btnAddRenter.Size = new System.Drawing.Size(24, 24);
            this.btnAddRenter.TabIndex = 174;
            this.btnAddRenter.UseVisualStyleBackColor = true;
            // 
            // cboContractType
            // 
            this.cboContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContractType.FormattingEnabled = true;
            this.cboContractType.Items.AddRange(new object[] {
            "นาย",
            "นาง",
            "นางสาว"});
            this.cboContractType.Location = new System.Drawing.Point(136, 191);
            this.cboContractType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboContractType.Name = "cboContractType";
            this.cboContractType.Size = new System.Drawing.Size(190, 24);
            this.cboContractType.TabIndex = 173;
            // 
            // dtpcheckout
            // 
            this.dtpcheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcheckout.Location = new System.Drawing.Point(426, 220);
            this.dtpcheckout.Name = "dtpcheckout";
            this.dtpcheckout.Size = new System.Drawing.Size(190, 24);
            this.dtpcheckout.TabIndex = 172;
            // 
            // lblcheckout
            // 
            this.lblcheckout.AutoSize = true;
            this.lblcheckout.Location = new System.Drawing.Point(347, 224);
            this.lblcheckout.Name = "lblcheckout";
            this.lblcheckout.Size = new System.Drawing.Size(58, 17);
            this.lblcheckout.TabIndex = 171;
            this.lblcheckout.Text = "วันที่ออก";
            // 
            // dtpcheckin
            // 
            this.dtpcheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcheckin.Location = new System.Drawing.Point(136, 220);
            this.dtpcheckin.Name = "dtpcheckin";
            this.dtpcheckin.Size = new System.Drawing.Size(190, 24);
            this.dtpcheckin.TabIndex = 170;
            // 
            // lblcheckin
            // 
            this.lblcheckin.AutoSize = true;
            this.lblcheckin.Location = new System.Drawing.Point(14, 224);
            this.lblcheckin.Name = "lblcheckin";
            this.lblcheckin.Size = new System.Drawing.Size(71, 17);
            this.lblcheckin.TabIndex = 169;
            this.lblcheckin.Text = "วันที่เข้าอยู่";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(136, 127);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(91, 24);
            this.txtRoom.TabIndex = 167;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(14, 130);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(50, 17);
            this.lblRoom.TabIndex = 168;
            this.lblRoom.Text = "ห้องพัก";
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContractDate.Location = new System.Drawing.Point(136, 64);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(190, 24);
            this.dtpContractDate.TabIndex = 166;
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Location = new System.Drawing.Point(14, 193);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(93, 17);
            this.lblContractType.TabIndex = 153;
            this.lblContractType.Text = "ประเภทสัญญา";
            // 
            // txtRecognizance
            // 
            this.txtRecognizance.Location = new System.Drawing.Point(136, 159);
            this.txtRecognizance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecognizance.Name = "txtRecognizance";
            this.txtRecognizance.Size = new System.Drawing.Size(190, 24);
            this.txtRecognizance.TabIndex = 35;
            this.txtRecognizance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecognizance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecognizance_KeyPress);
            // 
            // lblRecognizance
            // 
            this.lblRecognizance.AutoSize = true;
            this.lblRecognizance.Location = new System.Drawing.Point(14, 162);
            this.lblRecognizance.Name = "lblRecognizance";
            this.lblRecognizance.Size = new System.Drawing.Size(61, 17);
            this.lblRecognizance.TabIndex = 36;
            this.lblRecognizance.Text = "เงินมัดจำ";
            // 
            // lblContractDate
            // 
            this.lblContractDate.AutoSize = true;
            this.lblContractDate.Location = new System.Drawing.Point(14, 66);
            this.lblContractDate.Name = "lblContractDate";
            this.lblContractDate.Size = new System.Drawing.Size(91, 17);
            this.lblContractDate.TabIndex = 32;
            this.lblContractDate.Text = "วันที่ทำสัญญา";
            // 
            // txtRenterName
            // 
            this.txtRenterName.Location = new System.Drawing.Point(136, 95);
            this.txtRenterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRenterName.Name = "txtRenterName";
            this.txtRenterName.ReadOnly = true;
            this.txtRenterName.Size = new System.Drawing.Size(287, 24);
            this.txtRenterName.TabIndex = 6;
            // 
            // lblRenter
            // 
            this.lblRenter.AutoSize = true;
            this.lblRenter.Location = new System.Drawing.Point(14, 98);
            this.lblRenter.Name = "lblRenter";
            this.lblRenter.Size = new System.Drawing.Size(38, 17);
            this.lblRenter.TabIndex = 28;
            this.lblRenter.Text = "ผู้เช่า";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(136, 251);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(480, 55);
            this.txtRemark.TabIndex = 8;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(14, 254);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(63, 17);
            this.lblRemark.TabIndex = 14;
            this.lblRemark.Text = "หมายเหตุ";
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(136, 31);
            this.txtContractNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(190, 24);
            this.txtContractNo.TabIndex = 2;
            // 
            // lblContractNo
            // 
            this.lblContractNo.AutoSize = true;
            this.lblContractNo.Location = new System.Drawing.Point(14, 34);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(81, 17);
            this.lblContractNo.TabIndex = 11;
            this.lblContractNo.Text = "เลขที่สัญญา";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(235, 127);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(91, 24);
            this.txtRoomType.TabIndex = 176;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(332, 127);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(91, 24);
            this.textBox2.TabIndex = 177;
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 360);
            this.ControlBox = false;
            this.Controls.Add(this.gbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmContract";
            this.Text = "Contract";
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
        private System.Windows.Forms.TextBox txtContractNo;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Label lblContractDate;
        private System.Windows.Forms.TextBox txtRenterName;
        private System.Windows.Forms.Label lblRenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalofUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductUnitDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
        private System.Windows.Forms.TextBox txtRecognizance;
        private System.Windows.Forms.Label lblRecognizance;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.DateTimePicker dtpcheckout;
        private System.Windows.Forms.Label lblcheckout;
        private System.Windows.Forms.DateTimePicker dtpcheckin;
        private System.Windows.Forms.Label lblcheckin;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cboContractType;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnAddRenter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtRoomType;
    }
}