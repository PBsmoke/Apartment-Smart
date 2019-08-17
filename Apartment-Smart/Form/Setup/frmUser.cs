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
using ApartmentSmart.Class;
using ApartmentSmart.Data;

namespace ApartmentSmart
{
    public partial class frmUser : BaseInfoForm
    {
        public frmUser()
        {
            InitializeComponent();
        }

        #region Member
        string UserID = string.Empty;
        bool Success = true;
        ApartmentDB tblUser = new ApartmentDB();
        #endregion

        protected override void DoReset()
        {
            Utilities.ResetAllControls(this);
            UserID = string.Empty;
        }

        protected override void DoLoadForm()
        {
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                string sqlTmp = "";
                sqlTmp = "select * from tblUser";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblUser.Clear();
                da.Fill(tblUser, "tblUser");
                da.Dispose();
                dgvUser.DataSource = tblUser.tblUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CheckData()
        {

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("รหัสผู้ใช้ไม่สามารถเป็นค่าว่าง", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("กรุณากรอกรหัสผ่าน", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                return;
            }

            if (string.IsNullOrEmpty(txtConPassword.Text))
            {
                MessageBox.Show("กรุณากรอกยืนยันรหัสผ่าน", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                return;
            }

            if (txtPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("รหัสยืนยันไม่ถูกต้อง", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                return;
            }

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("กรุณาชื่อ", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                return;
            }
        }

        protected override void DoSave()
        {
            Success = true;
            CheckData();

            //Check Duplicate
            if (Success == true)
            {
                Success = Utilities.CheckDuplicate(tblUser.tblUser.TableName, tblUser.tblUser.UsernameColumn.ColumnName, txtUsername.Text);
                if (!Success)
                {
                    MessageBox.Show("รหัสผู้ใช้ซ้ำกรุณากรอกใหม่", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    txtUsername.Focus();
                    return;
                }
            }

            #region Save
            if (Success)
            {
                try
                {
                    dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                    StringBuilder StringBd = new StringBuilder();
                    //dbConString.Transaction = new SqlTransaction();
                    string sqlTmp = string.Empty;
                    StringBd.Append("INSERT INTO tblUser (UserID,Username,User_password,User_name) ");
                    StringBd.Append("VALUES (@UserID,@Username,@User_password,@User_name) ");
                    sqlTmp = "";
                    sqlTmp = StringBd.ToString();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Transaction = dbConString.Transaction;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString();
                    dbConString.Com.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text;
                    dbConString.Com.Parameters.Add("@User_password", SqlDbType.VarChar).Value = txtPassword.Text;
                    dbConString.Com.Parameters.Add("@User_name", SqlDbType.VarChar).Value = txtFullName.Text;
                    dbConString.Com.ExecuteNonQuery();
                    dbConString.Transaction.Commit();
                    MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
                catch
                {
                    dbConString.Transaction.Rollback();
                }
            }
            else
            {
                return;
            }
            #endregion

            ShowData();
            Utilities.ResetAllControls(this);
            UserID = string.Empty;
        }

        protected override void DoEdit()
        {
            Success = true;
            CheckData();

            if (Success)
            {
                Success = Utilities.CheckDuplicateNotInOldValues(tblUser.tblUser.TableName, tblUser.tblUser.UsernameColumn.ColumnName, txtUsername.Text, txtUsername.Text);
                if (!Success)
                {
                    MessageBox.Show("รหัสผู้ใช้ซ้ำกรุณากรอกใหม่", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    txtUsername.Focus();
                    return;
                }
            }

            #region Edit
            if (Success)
            {
                try
                {
                    dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                    StringBuilder StringBd = new StringBuilder();
                    //dbConString.Transaction = new SqlTransaction();
                    string sqlTmp = string.Empty;
                    StringBd.Append("UPDATE tblUser SET User_name = @User_name,Username = @Username,");
                    StringBd.Append("User_password = @User_password WHERE UserID = @UserID ");
                    sqlTmp = "";
                    sqlTmp = StringBd.ToString();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Transaction = dbConString.Transaction;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString();
                    dbConString.Com.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text;
                    dbConString.Com.Parameters.Add("@User_password", SqlDbType.VarChar).Value = txtPassword.Text;
                    dbConString.Com.Parameters.Add("@User_name", SqlDbType.VarChar).Value = txtFullName.Text;
                    dbConString.Com.ExecuteNonQuery();
                    dbConString.Transaction.Commit();
                    MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
                catch
                {
                    dbConString.Transaction.Rollback();
                }
            }
            else
            {
                return;
            }
            #endregion

            ShowData();
            Utilities.ResetAllControls(this);
            UserID = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region Delete
            if (Success)
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
                    StringBd.Append("DELETE tblUser WHERE UserID = @UserID");
                    sqlTmp = "";
                    sqlTmp = StringBd.ToString();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Transaction = dbConString.Transaction;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                    dbConString.Com.ExecuteNonQuery();
                    dbConString.Transaction.Commit();
                    MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                    Utilities.ResetAllControls(this);
                    UserID = string.Empty;
                }
                catch
                {
                    dbConString.Transaction.Rollback();
                }
            }
            else
            {
                return;
            }

            #endregion
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvUser.Rows[rowIndex];
            UserID = row.Cells[colUserID.Name].Value.ToString();
            txtUsername.Text = row.Cells[colUsername.Name].Value.ToString();
            txtFullName.Text = row.Cells[colUser_Name.Name].Value.ToString();
            btnStatus(false);
        }
    }
}
