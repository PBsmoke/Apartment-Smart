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
        ApartmentDB tblPayment = new ApartmentDB();
        bool Success = true;
        string Pay_ID = string.Empty;
        public string Type_Form = "ALL";
        int SelectRowIndex = 0;
        #endregion Member

        protected override void DoLoadForm()
        {
            DoVisibleSave(false);
            DoVisibleDeleted(false);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvShow.RowCount > 0)
            {
                frmPaymentDaily mForm = new frmPaymentDaily();
                mForm.Payment_ID = dgvShow.Rows[SelectRowIndex].Cells[colPay_ID.Name].Value.ToString();
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
            searchPayment();
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowIndex = e.RowIndex;
            btnStatus(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchPayment();
            SelectRowIndex = -1;
            btnStatus(true);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPayment();
                SelectRowIndex = -1;
                btnStatus(true);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchPayment();
            SelectRowIndex = -1;
            btnStatus(true);
        }

        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShow.RowCount > 0)
            {
                frmPaymentDaily mForm = new frmPaymentDaily();
                mForm.Payment_ID = dgvShow.Rows[SelectRowIndex].Cells[colPay_ID.Name].Value.ToString();
                mForm.ShowDialog();
                btnStatus(true);
            }

            txtSearch.Text = string.Empty;
            ShowData();
        }

        private void searchPayment()
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
            sqlTmp = "SELECT * FROM uv_payment  ";
            if (Type_Form.ToUpper().Equals("ALL"))
            {
                sqlTmp += " WHERE 1=1 ";
            }
            else
            {
                sqlTmp += " WHERE PaymentStatus = 'ค้างชำระ' ";
            }

            if (!string.IsNullOrEmpty(Whereclause))
            {
                sqlTmp += " and (Room_number LIKE '%" + Whereclause + "%' OR RenterFullname LIKE '%" + Whereclause + "%')";
            }
            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblPayment.Clear();
            da.Fill(tblPayment, "uv_payment");
            da.Dispose();
            dgvShow.DataSource = tblPayment.uv_payment;
        }
    }
}
