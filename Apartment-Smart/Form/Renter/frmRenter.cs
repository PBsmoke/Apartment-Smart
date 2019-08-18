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
    public partial class frmRenter : BaseInfo
    {
        public frmRenter()
        {
            InitializeComponent();
        }

        #region Member
        public string FormState = "NEW";
        bool Success = true;
        public string Renter_ID = string.Empty;
        int RowDtIndex = 0;
        SqlDataReader drTmp;
        ApartmentDB tblRenter = new ApartmentDB();
        #endregion Member

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void DoLoadForm()
        {
            if (!string.IsNullOrEmpty(Renter_ID))
            {
                ShowData(Renter_ID);
            }
            else
            {
                txtFirstname.Focus();
            }

        }

        protected override void DoReset()
        {
            Utilities.ResetAllControls(this);
            Renter_ID = string.Empty;
        }

        protected override void DoSave()
        {
            Success = true;
            CheckData();

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            if (FormState == "NEW")
            {
                #region Save
                if (Success)
                {
                    try
                    {
                        Renter_ID = Guid.NewGuid().ToString();
                        dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBuilder StringBd = new StringBuilder();
                        //dbConString.Transaction = new SqlTransaction();
                        string sqlTmp = string.Empty;
                        StringBd.Append("INSERT INTO tblRenter(Renter_ID, Renter_TitleName, Renter_Name, Renter_Lastname, Renter_Nationality, ");
                        StringBd.Append("Renter_Card, Renter_Address, Renter_Tel, Renter_Remark) ");
                        StringBd.Append("VALUES(@Renter_ID, @Renter_TitleName, @Renter_Name, @Renter_Lastname, @Renter_Nationality, ");
                        StringBd.Append("@Renter_Card, @Renter_Address, @Renter_Tel, @Renter_Remark) ");
                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = Renter_ID;
                        dbConString.Com.Parameters.Add("@Renter_TitleName", SqlDbType.VarChar).Value = cboTitleName.Text;
                        dbConString.Com.Parameters.Add("@Renter_Name", SqlDbType.VarChar).Value = txtFirstname.Text;
                        dbConString.Com.Parameters.Add("@Renter_Lastname", SqlDbType.VarChar).Value = txtLastname.Text;
                        dbConString.Com.Parameters.Add("@Renter_Nationality", SqlDbType.VarChar).Value = txtNationality.Text;
                        dbConString.Com.Parameters.Add("@Renter_Card", SqlDbType.VarChar).Value = txtCradID.Text;
                        dbConString.Com.Parameters.Add("@Renter_Address", SqlDbType.VarChar).Value = txtAddress.Text;
                        dbConString.Com.Parameters.Add("@Renter_Tel", SqlDbType.VarChar).Value = txtTel.Text;
                        dbConString.Com.Parameters.Add("@Renter_Remark", SqlDbType.VarChar).Value = txtRemark.Text;
                        dbConString.Com.ExecuteNonQuery();
                        dbConString.Transaction.Commit();                      

                        MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (FormState == "EDIT")
            {
                #region Edit
                if (Success)
                {
                    try
                    {

                        dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBuilder StringBd = new StringBuilder();
                        string sqlTmp = string.Empty;                       

                        StringBd.Clear();
                        StringBd.Append("UPDATE tblRenter SET Renter_TitleName = @Renter_TitleName, Renter_Name = @Renter_Name, Renter_Lastname = @Renter_Lastname ");
                        StringBd.Append(" , Renter_Nationality = @Renter_Nationality, Renter_Card = @Renter_Card, Renter_Address = @Renter_Address, Renter_Tel = @Renter_Tel ");
                        StringBd.Append(" , Renter_Remark = @Renter_Remark WHERE Renter_ID = @Renter_ID ");

                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = Renter_ID;
                        dbConString.Com.Parameters.Add("@Renter_TitleName", SqlDbType.VarChar).Value = cboTitleName.Text;
                        dbConString.Com.Parameters.Add("@Renter_Name", SqlDbType.VarChar).Value = txtFirstname.Text;
                        dbConString.Com.Parameters.Add("@Renter_Lastname", SqlDbType.VarChar).Value = txtLastname.Text;
                        dbConString.Com.Parameters.Add("@Renter_Nationality", SqlDbType.VarChar).Value = txtNationality.Text;
                        dbConString.Com.Parameters.Add("@Renter_Card", SqlDbType.VarChar).Value = txtCradID.Text;
                        dbConString.Com.Parameters.Add("@Renter_Address", SqlDbType.VarChar).Value = txtAddress.Text;
                        dbConString.Com.Parameters.Add("@Renter_Tel", SqlDbType.VarChar).Value = txtTel.Text;
                        dbConString.Com.Parameters.Add("@Renter_Remark", SqlDbType.VarChar).Value = txtRemark.Text;
                        dbConString.Com.ExecuteNonQuery();
                        dbConString.Transaction.Commit();

                        MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
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
        }

        private void ShowData(string Renter_ID)
        {
            if (!string.IsNullOrEmpty(Renter_ID))
            {
                #region Get date renter
                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblRenter WHERE Renter_ID = '" + Renter_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = Renter_ID;
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tblRenter.Clear();
                    da.Fill(tblRenter, "tblRenter");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                #endregion

                if (tblRenter.tblRenter.Rows.Count > 0)
                {

                    cboTitleName.Text = tblRenter.tblRenter[0].Renter_TitleName;
                    txtFirstname.Text = tblRenter.tblRenter[0].Renter_Name;
                    txtLastname.Text = tblRenter.tblRenter[0].Renter_Lastname;
                    txtCradID.Text = tblRenter.tblRenter[0].Renter_Card;
                    txtTel.Text = tblRenter.tblRenter[0].Renter_Tel;
                    txtNationality.Text = tblRenter.tblRenter[0].Renter_Nationality;
                    txtAddress.Text = tblRenter.tblRenter[0].Renter_Address;
                    txtRemark.Text = tblRenter.tblRenter[0].Renter_Remark;
                }
            }
            
        }

        private void CheckData()
        {

            if (string.IsNullOrEmpty(txtFirstname.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อ", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtFirstname.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtLastname.Text))
            {
                MessageBox.Show("กรุณากรอกนามสกุล", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtLastname.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCradID.Text))
            {
                MessageBox.Show("กรุณากรอกเลขบัตรประชาชน", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtLastname.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtLastname.Focus();
                return;
            }
        }                        
    }
}
