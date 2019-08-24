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
    public partial class frmContractList : BaseList
    {
        public frmContractList()
        {
            InitializeComponent();
        }

        #region Member
        ApartmentDB tblRenter = new ApartmentDB();
        bool Success = true;
        string Contract_ID = string.Empty;
        int SelectRowIndex = 0;
        #endregion Member

        protected override void DoLoadForm()
        {
            ShowData();
        }

        protected override void DoNew()
        {
            frmContract mForm = new frmContract();
            mForm.FormState = "NEW";
            mForm.ShowDialog();
            btnStatus(true);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvShow.RowCount > 0)
            {
                frmContract mForm = new frmContract();
                mForm.FormState = "EDIT";
                mForm.Contract_ID = dgvShow.Rows[SelectRowIndex].Cells[colContract_ID.Name].Value.ToString();
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
                Contract_ID = dgvShow.Rows[SelectRowIndex].Cells[colContract_ID.Name].Value.ToString();
                StringBd.Append("DELETE tblContract WHERE Contract_ID = @Contract_ID;");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = Contract_ID;
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
            searchContract();
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowIndex = e.RowIndex;
            btnStatus(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchContract();
            SelectRowIndex = -1;
            btnStatus(true);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchContract();
                SelectRowIndex = -1;
                btnStatus(true);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchContract();
            SelectRowIndex = -1;
            btnStatus(true);
        }

        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShow.RowCount > 0)
            {
                frmContract mForm = new frmContract();
                mForm.FormState = "EDIT";
                mForm.Contract_ID = dgvShow.Rows[SelectRowIndex].Cells[colContract_ID.Name].Value.ToString();
                mForm.ShowDialog();
                btnStatus(true);
            }

            txtSearch.Text = string.Empty;
            ShowData();
        }

        private void searchContract()
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
            sqlTmp = "SELECT c.Contract_ID, (rent.Renter_TitleName + ' ' + rent.Renter_Name + ' ' + rent.Renter_Lastname)AS Renter_ID, ";
            sqlTmp += " r.Room_number AS Room_ID, c.Contract_No, c.Contract_Date, c.Contract_Recognizance, ";
            sqlTmp += " cstatus.Name AS Contract_Status,ctype.Name AS Contract_Type,c.Date_Checkin,c.Date_Checkout,c.power_first, ";
            sqlTmp += " c.water_first,c.room_price,c.Remark ";
            sqlTmp += " FROM tblContract c ";
            sqlTmp += " INNER JOIN tblRoom r on c.Room_ID = r.Room_ID ";
            sqlTmp += " INNER JOIN tblStatus ctype on c.Contract_Type = ctype.StatusID ";
            sqlTmp += " INNER JOIN tblStatus cstatus on c.Contract_Status = cstatus.StatusID ";
            sqlTmp += " INNER JOIN tblRenter rent on c.Renter_ID = rent.Renter_ID ";

            if (!string.IsNullOrEmpty(Whereclause))
            {
                sqlTmp += " where c.Contract_No LIKE '%" + Whereclause + "%' or r.Room_number LIKE '%" + Whereclause + "%' or rent.Renter_Name LIKE '%" + Whereclause + "%' ";
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