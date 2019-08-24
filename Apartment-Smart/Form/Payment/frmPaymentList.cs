using System;
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
    public partial class frmPaymentList : BaseList
    {
        public frmPaymentList()
        {
            InitializeComponent();
        }

        #region Member
        ApartmentDB tblRoom = new ApartmentDB();
        bool Success = true;
        string Pay_ID = string.Empty;
        int SelectRowIndex = 0;
        #endregion Member

        protected override void DoLoadForm()
        {
            ShowData();
        }

        protected override void DoNew()
        {
            frmPayment mForm = new frmPayment();
            //mForm.FormState = "NEW";
            //mForm.ShowDialog();
            btnStatus(true);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvShow.RowCount > 0)
            {
                frmPayment mForm = new frmPayment();
                //mForm.FormState = "EDIT";
                //mForm.Room_ID = dgvShow.Rows[SelectRowIndex].Cells[colPay_ID.Name].Value.ToString();
                //mForm.ShowDialog();
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
                Pay_ID = dgvShow.Rows[SelectRowIndex].Cells[colPay_ID.Name].Value.ToString();
                StringBd.Append("DELETE tblPayment WHERE Pay_ID = @Pay_ID;");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = Pay_ID;
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
                frmPayment mForm = new frmPayment();
                //mForm.FormState = "EDIT";
                //mForm.Room_ID = dgvShow.Rows[SelectRowIndex].Cells[colRoom_ID.Name].Value.ToString();
                mForm.ShowDialog();
                btnStatus(true);
            }

            txtSearch.Text = string.Empty;
            ShowData();
        }

        private void searchRoom()
        {
            //string sqlTmp = string.Empty;
            //string Whereclause = string.Empty;
            //if (!string.IsNullOrEmpty(txtSearch.Text))
            //{
            //    Whereclause = txtSearch.Text;
            //}
            //else
            //{
            //    Whereclause = string.Empty;
            //}
            //sqlTmp = "select r.Room_ID,	r.Room_number, r.Room_floor, s.Name AS Room_Type, r.Room_Price_daily, r.Room_Price_monthly, ";
            //sqlTmp += "	s1.Name AS Room_status, r.Room_MetersNo, r.Room_Remark from tblRoom r INNER JOIN tblStatus s ON r.Room_Type = s.StatusID ";
            //sqlTmp += " INNER JOIN tblStatus s1 ON r.Room_status = s1.StatusID ";
            //if (!string.IsNullOrEmpty(Whereclause))
            //{
            //    sqlTmp += " WHERE r.Room_number LIKE '%" + Whereclause + "%' OR s.Name LIKE '%" + Whereclause + "%' ";
            //}
            //DataSet Ds = new DataSet();
            //dbConString.Com = new SqlCommand();
            //dbConString.Com.CommandType = CommandType.Text;
            //dbConString.Com.CommandText = sqlTmp;
            //dbConString.Com.Connection = dbConString.mySQLConn;
            //SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //tblRoom.Clear();
            //da.Fill(tblRoom, "tblRoom");
            //da.Dispose();
            //dgvShow.DataSource = tblRoom.tblRoom;
        }
    }
}
