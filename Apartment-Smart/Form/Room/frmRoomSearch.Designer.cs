namespace ApartmentSmart
{
    partial class frmRoomSearch
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
            this.uvroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colRoom_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Price_daily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Price_monthly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_MetersNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvroomBindingSource)).BeginInit();
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
            this.colRoom_ID,
            this.colRoom_number,
            this.colRoom_floor,
            this.colRoom_Type,
            this.colRoomType,
            this.colRoom_Price_daily,
            this.colRoom_Price_monthly,
            this.colRoom_status,
            this.colRoomStatus,
            this.colRoom_MetersNo,
            this.colRoom_Remark});
            this.dgvProductSearch.DataSource = this.uvroomBindingSource;
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
            // uvroomBindingSource
            // 
            this.uvroomBindingSource.DataMember = "uv_room";
            this.uvroomBindingSource.DataSource = this.apartmentDB;
            // 
            // colRoom_ID
            // 
            this.colRoom_ID.DataPropertyName = "Room_ID";
            this.colRoom_ID.HeaderText = "Room_ID";
            this.colRoom_ID.Name = "colRoom_ID";
            this.colRoom_ID.ReadOnly = true;
            this.colRoom_ID.Visible = false;
            // 
            // colRoom_number
            // 
            this.colRoom_number.DataPropertyName = "Room_number";
            this.colRoom_number.HeaderText = "เลขที่ห้อง";
            this.colRoom_number.Name = "colRoom_number";
            this.colRoom_number.ReadOnly = true;
            // 
            // colRoom_floor
            // 
            this.colRoom_floor.DataPropertyName = "Room_floor";
            this.colRoom_floor.HeaderText = "ชั้น";
            this.colRoom_floor.Name = "colRoom_floor";
            this.colRoom_floor.ReadOnly = true;
            // 
            // colRoom_Type
            // 
            this.colRoom_Type.DataPropertyName = "Room_Type";
            this.colRoom_Type.HeaderText = "Room_Type";
            this.colRoom_Type.Name = "colRoom_Type";
            this.colRoom_Type.ReadOnly = true;
            this.colRoom_Type.Visible = false;
            // 
            // colRoomType
            // 
            this.colRoomType.DataPropertyName = "RoomType";
            this.colRoomType.HeaderText = "ประเภทห้องพัก";
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            // 
            // colRoom_Price_daily
            // 
            this.colRoom_Price_daily.DataPropertyName = "Room_Price_daily";
            this.colRoom_Price_daily.HeaderText = "ราคารายวัน";
            this.colRoom_Price_daily.Name = "colRoom_Price_daily";
            this.colRoom_Price_daily.ReadOnly = true;
            // 
            // colRoom_Price_monthly
            // 
            this.colRoom_Price_monthly.DataPropertyName = "Room_Price_monthly";
            this.colRoom_Price_monthly.HeaderText = "ราคารายเดือน";
            this.colRoom_Price_monthly.Name = "colRoom_Price_monthly";
            this.colRoom_Price_monthly.ReadOnly = true;
            // 
            // colRoom_status
            // 
            this.colRoom_status.DataPropertyName = "Room_status";
            this.colRoom_status.HeaderText = "Room_status";
            this.colRoom_status.Name = "colRoom_status";
            this.colRoom_status.ReadOnly = true;
            this.colRoom_status.Visible = false;
            // 
            // colRoomStatus
            // 
            this.colRoomStatus.DataPropertyName = "RoomStatus";
            this.colRoomStatus.HeaderText = "สถานะ";
            this.colRoomStatus.Name = "colRoomStatus";
            this.colRoomStatus.ReadOnly = true;
            // 
            // colRoom_MetersNo
            // 
            this.colRoom_MetersNo.DataPropertyName = "Room_MetersNo";
            this.colRoom_MetersNo.HeaderText = "Room_MetersNo";
            this.colRoom_MetersNo.Name = "colRoom_MetersNo";
            this.colRoom_MetersNo.ReadOnly = true;
            this.colRoom_MetersNo.Visible = false;
            // 
            // colRoom_Remark
            // 
            this.colRoom_Remark.DataPropertyName = "Room_Remark";
            this.colRoom_Remark.HeaderText = "Room_Remark";
            this.colRoom_Remark.Name = "colRoom_Remark";
            this.colRoom_Remark.ReadOnly = true;
            this.colRoom_Remark.Visible = false;
            // 
            // frmRoomSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 414);
            this.Controls.Add(this.dgvProductSearch);
            this.Controls.Add(this.gbProductSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRoomSearch";
            this.Text = "ค้นหาห้องพัก";
            this.Load += new System.EventHandler(this.frmProductSearch_Load);
            this.gbProductSearch.ResumeLayout(false);
            this.gbProductSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvroomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductSearch;
        private System.Windows.Forms.DataGridView dgvProductSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private Data.ApartmentDB apartmentDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Price_daily;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Price_monthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_MetersNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom_Remark;
        private System.Windows.Forms.BindingSource uvroomBindingSource;
    }
}