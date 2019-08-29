namespace ApartmentSmart
{
    partial class frmPayment
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.btnAddRenter = new System.Windows.Forms.Button();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRenterName = new System.Windows.Forms.TextBox();
            this.lblRenter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.textBox2);
            this.gbProduct.Controls.Add(this.textBox1);
            this.gbProduct.Controls.Add(this.label3);
            this.gbProduct.Controls.Add(this.comboBox3);
            this.gbProduct.Controls.Add(this.dataGridView1);
            this.gbProduct.Controls.Add(this.button1);
            this.gbProduct.Controls.Add(this.label2);
            this.gbProduct.Controls.Add(this.label1);
            this.gbProduct.Controls.Add(this.txtRoomType);
            this.gbProduct.Controls.Add(this.btnAddRenter);
            this.gbProduct.Controls.Add(this.txtRoom);
            this.gbProduct.Controls.Add(this.lblRoom);
            this.gbProduct.Controls.Add(this.txtRenterName);
            this.gbProduct.Controls.Add(this.lblRenter);
            this.gbProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProduct.Location = new System.Drawing.Point(0, 39);
            this.gbProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbProduct.Size = new System.Drawing.Size(617, 307);
            this.gbProduct.TabIndex = 122;
            this.gbProduct.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(327, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 50);
            this.button1.TabIndex = 196;
            this.button1.Text = "พิมพ์ใบเสร็จ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 180;
            this.label2.Text = "เดือน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 179;
            this.label1.Text = "ปี";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(266, 57);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(91, 24);
            this.txtRoomType.TabIndex = 176;
            // 
            // btnAddRenter
            // 
            this.btnAddRenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRenter.Location = new System.Drawing.Point(363, 24);
            this.btnAddRenter.Name = "btnAddRenter";
            this.btnAddRenter.Size = new System.Drawing.Size(60, 60);
            this.btnAddRenter.TabIndex = 174;
            this.btnAddRenter.UseVisualStyleBackColor = true;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(70, 57);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(177, 24);
            this.txtRoom.TabIndex = 167;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(18, 60);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(50, 17);
            this.lblRoom.TabIndex = 168;
            this.lblRoom.Text = "ห้องพัก";
            // 
            // txtRenterName
            // 
            this.txtRenterName.Location = new System.Drawing.Point(70, 25);
            this.txtRenterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRenterName.Name = "txtRenterName";
            this.txtRenterName.ReadOnly = true;
            this.txtRenterName.Size = new System.Drawing.Size(287, 24);
            this.txtRenterName.TabIndex = 6;
            // 
            // lblRenter
            // 
            this.lblRenter.AutoSize = true;
            this.lblRenter.Location = new System.Drawing.Point(18, 28);
            this.lblRenter.Name = "lblRenter";
            this.lblRenter.Size = new System.Drawing.Size(38, 17);
            this.lblRenter.TabIndex = 28;
            this.lblRenter.Text = "ผู้เช่า";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 150);
            this.dataGridView1.TabIndex = 199;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 201;
            this.label3.Text = "สถานะ";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(78, 247);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(243, 24);
            this.comboBox3.TabIndex = 200;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(478, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 24);
            this.textBox1.TabIndex = 202;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(478, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(121, 24);
            this.textBox2.TabIndex = 203;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 348);
            this.Controls.Add(this.gbProduct);
            this.Name = "frmPayment";
            this.Text = "บันทึกการชำระเงิน";
            this.Controls.SetChildIndex(this.gbProduct, 0);
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Button btnAddRenter;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRenterName;
        private System.Windows.Forms.Label lblRenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}