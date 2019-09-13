namespace ApartmentSmart
{
    partial class frmPaymentDaily
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
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.Label();
            this.lblStatsu = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRecognizance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateCheckOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateCheckIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.dgvPaymentDetail = new System.Windows.Forms.DataGridView();
            this.colPayDT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPay_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPaymentDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartmentDB = new ApartmentSmart.Data.ApartmentDB();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtRoomfloor = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRenterName = new System.Windows.Forms.TextBox();
            this.lblRenter = new System.Windows.Forms.Label();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.btnReset);
            this.gbProduct.Controls.Add(this.txtStatus);
            this.gbProduct.Controls.Add(this.lblStatsu);
            this.gbProduct.Controls.Add(this.lblNet);
            this.gbProduct.Controls.Add(this.lblSumPrice);
            this.gbProduct.Controls.Add(this.txtAmount);
            this.gbProduct.Controls.Add(this.lblNumber);
            this.gbProduct.Controls.Add(this.txtDetail);
            this.gbProduct.Controls.Add(this.lblProductName);
            this.gbProduct.Controls.Add(this.btnDel);
            this.gbProduct.Controls.Add(this.btnAdd);
            this.gbProduct.Controls.Add(this.label8);
            this.gbProduct.Controls.Add(this.txtRecognizance);
            this.gbProduct.Controls.Add(this.label7);
            this.gbProduct.Controls.Add(this.label6);
            this.gbProduct.Controls.Add(this.txtNumberDay);
            this.gbProduct.Controls.Add(this.label5);
            this.gbProduct.Controls.Add(this.txtDateCheckOut);
            this.gbProduct.Controls.Add(this.label4);
            this.gbProduct.Controls.Add(this.txtDateCheckIn);
            this.gbProduct.Controls.Add(this.label3);
            this.gbProduct.Controls.Add(this.btnPrint);
            this.gbProduct.Controls.Add(this.label2);
            this.gbProduct.Controls.Add(this.txtContractNo);
            this.gbProduct.Controls.Add(this.lblContractNo);
            this.gbProduct.Controls.Add(this.dgvPaymentDetail);
            this.gbProduct.Controls.Add(this.btnPayment);
            this.gbProduct.Controls.Add(this.txtRoomfloor);
            this.gbProduct.Controls.Add(this.txtRoomNo);
            this.gbProduct.Controls.Add(this.lblRoom);
            this.gbProduct.Controls.Add(this.txtRenterName);
            this.gbProduct.Controls.Add(this.lblRenter);
            this.gbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProduct.Location = new System.Drawing.Point(0, 39);
            this.gbProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Size = new System.Drawing.Size(887, 351);
            this.gbProduct.TabIndex = 122;
            this.gbProduct.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::ApartmentSmart.Properties.Resources.repeat;
            this.btnReset.Location = new System.Drawing.Point(624, 108);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(32, 32);
            this.btnReset.TabIndex = 227;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtStatus.Location = new System.Drawing.Point(93, 298);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(276, 43);
            this.txtStatus.TabIndex = 226;
            this.txtStatus.Text = "Net";
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatsu
            // 
            this.lblStatsu.AutoSize = true;
            this.lblStatsu.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblStatsu.Location = new System.Drawing.Point(12, 313);
            this.lblStatsu.Name = "lblStatsu";
            this.lblStatsu.Size = new System.Drawing.Size(78, 27);
            this.lblStatsu.TabIndex = 225;
            this.lblStatsu.Text = "สถานะ";
            // 
            // lblNet
            // 
            this.lblNet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNet.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblNet.Location = new System.Drawing.Point(599, 298);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(276, 43);
            this.lblNet.TabIndex = 224;
            this.lblNet.Text = "Net";
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSumPrice.Location = new System.Drawing.Point(491, 313);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(102, 27);
            this.lblSumPrice.TabIndex = 222;
            this.lblSumPrice.Text = "รวมราคา";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(416, 113);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(126, 24);
            this.txtAmount.TabIndex = 221;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(332, 116);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(37, 17);
            this.lblNumber.TabIndex = 220;
            this.lblNumber.Text = "ราคา";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(94, 113);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(214, 24);
            this.txtDetail.TabIndex = 219;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 116);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(50, 17);
            this.lblProductName.TabIndex = 218;
            this.lblProductName.Text = "รายการ";
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Image = global::ApartmentSmart.Properties.Resources.minus;
            this.btnDel.Location = new System.Drawing.Point(586, 108);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(32, 32);
            this.btnDel.TabIndex = 217;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::ApartmentSmart.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(548, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 216;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(810, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 215;
            this.label8.Text = "บาท";
            // 
            // txtRecognizance
            // 
            this.txtRecognizance.Location = new System.Drawing.Point(713, 82);
            this.txtRecognizance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecognizance.Name = "txtRecognizance";
            this.txtRecognizance.ReadOnly = true;
            this.txtRecognizance.Size = new System.Drawing.Size(91, 24);
            this.txtRecognizance.TabIndex = 214;
            this.txtRecognizance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 213;
            this.label7.Text = "เงินมัดจำ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(810, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 212;
            this.label6.Text = "วัน";
            // 
            // txtNumberDay
            // 
            this.txtNumberDay.Location = new System.Drawing.Point(713, 50);
            this.txtNumberDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberDay.Name = "txtNumberDay";
            this.txtNumberDay.ReadOnly = true;
            this.txtNumberDay.Size = new System.Drawing.Size(91, 24);
            this.txtNumberDay.TabIndex = 211;
            this.txtNumberDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 210;
            this.label5.Text = "จำนวนวันที่พัก";
            // 
            // txtDateCheckOut
            // 
            this.txtDateCheckOut.Location = new System.Drawing.Point(416, 50);
            this.txtDateCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateCheckOut.Name = "txtDateCheckOut";
            this.txtDateCheckOut.ReadOnly = true;
            this.txtDateCheckOut.Size = new System.Drawing.Size(177, 24);
            this.txtDateCheckOut.TabIndex = 209;
            this.txtDateCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 208;
            this.label4.Text = "วันที่ออก";
            // 
            // txtDateCheckIn
            // 
            this.txtDateCheckIn.Location = new System.Drawing.Point(94, 50);
            this.txtDateCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateCheckIn.Name = "txtDateCheckIn";
            this.txtDateCheckIn.ReadOnly = true;
            this.txtDateCheckIn.Size = new System.Drawing.Size(177, 24);
            this.txtDateCheckIn.TabIndex = 207;
            this.txtDateCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 206;
            this.label3.Text = "วันที่เข้าพัก";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(599, 222);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(272, 70);
            this.btnPrint.TabIndex = 205;
            this.btnPrint.Text = "พิมพ์ใบเสร็จ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 204;
            this.label2.Text = "ขั้น";
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(94, 18);
            this.txtContractNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.ReadOnly = true;
            this.txtContractNo.Size = new System.Drawing.Size(177, 24);
            this.txtContractNo.TabIndex = 203;
            // 
            // lblContractNo
            // 
            this.lblContractNo.AutoSize = true;
            this.lblContractNo.Location = new System.Drawing.Point(12, 21);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(81, 17);
            this.lblContractNo.TabIndex = 202;
            this.lblContractNo.Text = "เลขที่สัญญา";
            // 
            // dgvPaymentDetail
            // 
            this.dgvPaymentDetail.AllowUserToAddRows = false;
            this.dgvPaymentDetail.AllowUserToDeleteRows = false;
            this.dgvPaymentDetail.AutoGenerateColumns = false;
            this.dgvPaymentDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPayDT_ID,
            this.colPay_ID,
            this.colDetail,
            this.colAmount});
            this.dgvPaymentDetail.DataSource = this.tblPaymentDTBindingSource;
            this.dgvPaymentDetail.Location = new System.Drawing.Point(15, 146);
            this.dgvPaymentDetail.Name = "dgvPaymentDetail";
            this.dgvPaymentDetail.ReadOnly = true;
            this.dgvPaymentDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentDetail.Size = new System.Drawing.Size(578, 146);
            this.dgvPaymentDetail.TabIndex = 199;
            this.dgvPaymentDetail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPaymentDetail_CellMouseClick);
            // 
            // colPayDT_ID
            // 
            this.colPayDT_ID.DataPropertyName = "PayDT_ID";
            this.colPayDT_ID.HeaderText = "PayDT_ID";
            this.colPayDT_ID.Name = "colPayDT_ID";
            this.colPayDT_ID.ReadOnly = true;
            this.colPayDT_ID.Visible = false;
            // 
            // colPay_ID
            // 
            this.colPay_ID.DataPropertyName = "Pay_ID";
            this.colPay_ID.HeaderText = "Pay_ID";
            this.colPay_ID.Name = "colPay_ID";
            this.colPay_ID.ReadOnly = true;
            this.colPay_ID.Visible = false;
            // 
            // colDetail
            // 
            this.colDetail.DataPropertyName = "Detail";
            this.colDetail.FillWeight = 200F;
            this.colDetail.HeaderText = "รายการ";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colAmount.HeaderText = "ราคา";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // tblPaymentDTBindingSource
            // 
            this.tblPaymentDTBindingSource.DataMember = "tblPaymentDT";
            this.tblPaymentDTBindingSource.DataSource = this.apartmentDB;
            // 
            // apartmentDB
            // 
            this.apartmentDB.DataSetName = "ApartmentDB";
            this.apartmentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Location = new System.Drawing.Point(599, 146);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(272, 70);
            this.btnPayment.TabIndex = 196;
            this.btnPayment.Text = "ชำระเงิน";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtRoomfloor
            // 
            this.txtRoomfloor.Location = new System.Drawing.Point(416, 82);
            this.txtRoomfloor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomfloor.Name = "txtRoomfloor";
            this.txtRoomfloor.ReadOnly = true;
            this.txtRoomfloor.Size = new System.Drawing.Size(91, 24);
            this.txtRoomfloor.TabIndex = 176;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(94, 82);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.ReadOnly = true;
            this.txtRoomNo.Size = new System.Drawing.Size(177, 24);
            this.txtRoomNo.TabIndex = 167;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(12, 85);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(50, 17);
            this.lblRoom.TabIndex = 168;
            this.lblRoom.Text = "ห้องพัก";
            // 
            // txtRenterName
            // 
            this.txtRenterName.Location = new System.Drawing.Point(416, 18);
            this.txtRenterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRenterName.Name = "txtRenterName";
            this.txtRenterName.ReadOnly = true;
            this.txtRenterName.Size = new System.Drawing.Size(455, 24);
            this.txtRenterName.TabIndex = 6;
            // 
            // lblRenter
            // 
            this.lblRenter.AutoSize = true;
            this.lblRenter.Location = new System.Drawing.Point(332, 21);
            this.lblRenter.Name = "lblRenter";
            this.lblRenter.Size = new System.Drawing.Size(38, 17);
            this.lblRenter.TabIndex = 28;
            this.lblRenter.Text = "ผู้เช่า";
            // 
            // frmPaymentDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 390);
            this.Controls.Add(this.gbProduct);
            this.Name = "frmPaymentDaily";
            this.Text = "บันทึกการชำระเงิน";
            this.Controls.SetChildIndex(this.gbProduct, 0);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TextBox txtRoomfloor;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRenterName;
        private System.Windows.Forms.Label lblRenter;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.DataGridView dgvPaymentDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContractNo;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDateCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRecognizance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.BindingSource tblPaymentDTBindingSource;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label lblStatsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayDT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.Button btnReset;
    }
}