﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ApartmentSmart.Data;
using ApartmentSmart.Class;

namespace ApartmentSmart
{
    public partial class frmRenterList : BaseList
    {
        public frmRenterList()
        {
            InitializeComponent();
        }

        #region Member
        ApartmentDB tblRenter = new ApartmentDB();
        bool Success = true;
        string Renter_ID = string.Empty;
        int SelectRowIndex = 0;
        #endregion Member

        protected override void DoLoadForm()
        {
            ShowData();
        }

        protected override void DoNew()
        {
            frmRenter mForm = new frmRenter();
            mForm.FormState = "NEW";
            mForm.ShowDialog();
            btnStatus(true);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvShow.RowCount > 0)
            {
                frmRenter mForm = new frmRenter();
                mForm.FormState = "EDIT";
                mForm.Renter_ID = dgvShow.Rows[SelectRowIndex].Cells[colRenter_ID.Name].Value.ToString();
                mForm.ShowDialog();
                btnStatus(true);
            }
            txtSearch.Text = string.Empty;
            ShowData();
        }

        protected override void DoDelete()
        {
            if (MessageBox.Show("คุณต้องการลบข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            try
            {
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;
                Renter_ID = dgvShow.Rows[SelectRowIndex].Cells[colRenter_ID.Name].Value.ToString();
                StringBd.Append("DELETE tblRenter WHERE Renter_ID = @Renter_ID;");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = Renter_ID;
                dbConString.Com.ExecuteNonQuery();
                dbConString.Transaction.Commit();
                MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStatus(true);
                ShowData();
                Utilities.ResetAllControls(this);
            }
            catch
            {
                MessageBox.Show("ไม่สามารถลบข้อมูลสินค้าได้ เนื่องจากถูกนำไปใช้งานแล้ว", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dbConString.Transaction.Rollback();
            }
        }

        private void ShowData()
        {
            searchRoom();
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowIndex = e.RowIndex;
            btnStatus(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchRoom();
            SelectRowIndex = -1;
            btnStatus(true);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchRoom();
                SelectRowIndex = -1;
                btnStatus(true);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchRoom();
            SelectRowIndex = -1;
            btnStatus(true);
        }

        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShow.RowCount > 0)
            {
                frmRenter mForm = new frmRenter();
                mForm.FormState = "EDIT";
                mForm.Renter_ID = dgvShow.Rows[SelectRowIndex].Cells[colRenter_ID.Name].Value.ToString();
                mForm.ShowDialog();
                btnStatus(true);
            }

            txtSearch.Text = string.Empty;
            ShowData();
        }

        private void searchRoom()
        {
            string sqlTmp = string.Empty;
            string Whereclause = string.Empty;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Whereclause = txtSearch.Text;
            }
            else
            {
                Whereclause = string.Empty;
            }
            sqlTmp = "select * from tblRenter ";
            if (!string.IsNullOrEmpty(Whereclause))
            {
                sqlTmp += " where Renter_TitleName LIKE '%" + Whereclause + "%' or Renter_Name LIKE '%" + Whereclause + "%' or Renter_Lastname LIKE '%" + Whereclause + "%' or Renter_Tel LIKE '%" + Whereclause + "%' ";
            }
            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblRenter.Clear();
            da.Fill(tblRenter, "tblRenter");
            da.Dispose();
            dgvShow.DataSource = tblRenter.tblRenter;
        }
    }
}