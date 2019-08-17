namespace ApartmentSmart
{
    partial class frmRoom
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
            this.txtRoom_status = new System.Windows.Forms.TextBox();
            this.txtMetersNo = new System.Windows.Forms.TextBox();
            this.lblRoom_MetersNo = new System.Windows.Forms.Label();
            this.lblRoom_status = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoom_Type = new System.Windows.Forms.Label();
            this.txtPrice_monthly = new System.Windows.Forms.TextBox();
            this.lblRoom_Price_monthly = new System.Windows.Forms.Label();
            this.txtPrice_daily = new System.Windows.Forms.TextBox();
            this.lblRoom_Price_daily = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRoom_floor = new System.Windows.Forms.TextBox();
            this.txtRoom_number = new System.Windows.Forms.TextBox();
            this.lblRoom_floor = new System.Windows.Forms.Label();
            this.lblRoom_number = new System.Windows.Forms.Label();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.txtRoom_status);
            this.gbProduct.Controls.Add(this.txtMetersNo);
            this.gbProduct.Controls.Add(this.lblRoom_MetersNo);
            this.gbProduct.Controls.Add(this.lblRoom_status);
            this.gbProduct.Controls.Add(this.cboRoomType);
            this.gbProduct.Controls.Add(this.lblRoom_Type);
            this.gbProduct.Controls.Add(this.txtPrice_monthly);
            this.gbProduct.Controls.Add(this.lblRoom_Price_monthly);
            this.gbProduct.Controls.Add(this.txtPrice_daily);
            this.gbProduct.Controls.Add(this.lblRoom_Price_daily);
            this.gbProduct.Controls.Add(this.txtRemark);
            this.gbProduct.Controls.Add(this.lblRemark);
            this.gbProduct.Controls.Add(this.txtRoom_floor);
            this.gbProduct.Controls.Add(this.txtRoom_number);
            this.gbProduct.Controls.Add(this.lblRoom_floor);
            this.gbProduct.Controls.Add(this.lblRoom_number);
            this.gbProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProduct.Location = new System.Drawing.Point(0, 39);
            this.gbProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Size = new System.Drawing.Size(559, 253);
            this.gbProduct.TabIndex = 10;
            this.gbProduct.TabStop = false;
            // 
            // txtRoom_status
            // 
            this.txtRoom_status.Location = new System.Drawing.Point(406, 63);
            this.txtRoom_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom_status.Name = "txtRoom_status";
            this.txtRoom_status.Size = new System.Drawing.Size(130, 24);
            this.txtRoom_status.TabIndex = 37;
            // 
            // txtMetersNo
            // 
            this.txtMetersNo.Location = new System.Drawing.Point(153, 127);
            this.txtMetersNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMetersNo.Name = "txtMetersNo";
            this.txtMetersNo.Size = new System.Drawing.Size(130, 24);
            this.txtMetersNo.TabIndex = 35;
            // 
            // lblRoom_MetersNo
            // 
            this.lblRoom_MetersNo.AutoSize = true;
            this.lblRoom_MetersNo.Location = new System.Drawing.Point(14, 130);
            this.lblRoom_MetersNo.Name = "lblRoom_MetersNo";
            this.lblRoom_MetersNo.Size = new System.Drawing.Size(133, 17);
            this.lblRoom_MetersNo.TabIndex = 36;
            this.lblRoom_MetersNo.Text = "หมายเลขมิเตอร์ไฟฟ้า";
            // 
            // lblRoom_status
            // 
            this.lblRoom_status.AutoSize = true;
            this.lblRoom_status.Location = new System.Drawing.Point(302, 66);
            this.lblRoom_status.Name = "lblRoom_status";
            this.lblRoom_status.Size = new System.Drawing.Size(71, 17);
            this.lblRoom_status.TabIndex = 33;
            this.lblRoom_status.Text = "สถานะห้อง";
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(153, 63);
            this.cboRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(130, 24);
            this.cboRoomType.TabIndex = 4;
            // 
            // lblRoom_Type
            // 
            this.lblRoom_Type.AutoSize = true;
            this.lblRoom_Type.Location = new System.Drawing.Point(14, 66);
            this.lblRoom_Type.Name = "lblRoom_Type";
            this.lblRoom_Type.Size = new System.Drawing.Size(77, 17);
            this.lblRoom_Type.TabIndex = 32;
            this.lblRoom_Type.Text = "ประเภทห้อง";
            // 
            // txtPrice_monthly
            // 
            this.txtPrice_monthly.Location = new System.Drawing.Point(153, 95);
            this.txtPrice_monthly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice_monthly.Name = "txtPrice_monthly";
            this.txtPrice_monthly.Size = new System.Drawing.Size(130, 24);
            this.txtPrice_monthly.TabIndex = 6;
            this.txtPrice_monthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice_monthly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_monthly_KeyPress);
            // 
            // lblRoom_Price_monthly
            // 
            this.lblRoom_Price_monthly.AutoSize = true;
            this.lblRoom_Price_monthly.Location = new System.Drawing.Point(14, 98);
            this.lblRoom_Price_monthly.Name = "lblRoom_Price_monthly";
            this.lblRoom_Price_monthly.Size = new System.Drawing.Size(113, 17);
            this.lblRoom_Price_monthly.TabIndex = 28;
            this.lblRoom_Price_monthly.Text = "ราคาห้องรายเดือน";
            // 
            // txtPrice_daily
            // 
            this.txtPrice_daily.Location = new System.Drawing.Point(406, 95);
            this.txtPrice_daily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice_daily.Name = "txtPrice_daily";
            this.txtPrice_daily.Size = new System.Drawing.Size(130, 24);
            this.txtPrice_daily.TabIndex = 7;
            this.txtPrice_daily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice_daily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_daily_KeyPress);
            // 
            // lblRoom_Price_daily
            // 
            this.lblRoom_Price_daily.AutoSize = true;
            this.lblRoom_Price_daily.Location = new System.Drawing.Point(302, 98);
            this.lblRoom_Price_daily.Name = "lblRoom_Price_daily";
            this.lblRoom_Price_daily.Size = new System.Drawing.Size(98, 17);
            this.lblRoom_Price_daily.TabIndex = 26;
            this.lblRoom_Price_daily.Text = "ราคาห้องรายวัน";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(153, 160);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(383, 67);
            this.txtRemark.TabIndex = 8;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(14, 163);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(63, 17);
            this.lblRemark.TabIndex = 14;
            this.lblRemark.Text = "หมายเหตุ";
            // 
            // txtRoom_floor
            // 
            this.txtRoom_floor.Location = new System.Drawing.Point(406, 31);
            this.txtRoom_floor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom_floor.Name = "txtRoom_floor";
            this.txtRoom_floor.Size = new System.Drawing.Size(130, 24);
            this.txtRoom_floor.TabIndex = 2;
            // 
            // txtRoom_number
            // 
            this.txtRoom_number.Location = new System.Drawing.Point(153, 31);
            this.txtRoom_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom_number.Name = "txtRoom_number";
            this.txtRoom_number.Size = new System.Drawing.Size(130, 24);
            this.txtRoom_number.TabIndex = 1;
            // 
            // lblRoom_floor
            // 
            this.lblRoom_floor.AutoSize = true;
            this.lblRoom_floor.Location = new System.Drawing.Point(302, 31);
            this.lblRoom_floor.Name = "lblRoom_floor";
            this.lblRoom_floor.Size = new System.Drawing.Size(26, 17);
            this.lblRoom_floor.TabIndex = 11;
            this.lblRoom_floor.Text = "ชั้น";
            // 
            // lblRoom_number
            // 
            this.lblRoom_number.AutoSize = true;
            this.lblRoom_number.Location = new System.Drawing.Point(14, 34);
            this.lblRoom_number.Name = "lblRoom_number";
            this.lblRoom_number.Size = new System.Drawing.Size(65, 17);
            this.lblRoom_number.TabIndex = 10;
            this.lblRoom_number.Text = "เลขที่ห้อง";
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 281);
            this.ControlBox = false;
            this.Controls.Add(this.gbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmRoom";
            this.Text = "Room";
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
        private System.Windows.Forms.TextBox txtRoom_floor;
        private System.Windows.Forms.TextBox txtRoom_number;
        private System.Windows.Forms.Label lblRoom_floor;
        private System.Windows.Forms.Label lblRoom_number;
        private System.Windows.Forms.TextBox txtPrice_daily;
        private System.Windows.Forms.Label lblRoom_Price_daily;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblRoom_Type;
        private System.Windows.Forms.TextBox txtPrice_monthly;
        private System.Windows.Forms.Label lblRoom_Price_monthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalofUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductUnitDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitID;
        private System.Windows.Forms.Label lblRoom_status;
        private System.Windows.Forms.TextBox txtMetersNo;
        private System.Windows.Forms.Label lblRoom_MetersNo;
        private System.Windows.Forms.TextBox txtRoom_status;
    }
}