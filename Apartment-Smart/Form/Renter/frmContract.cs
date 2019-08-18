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
    public partial class frmContract : BaseInfo
    {
        public frmContract()
        {
            InitializeComponent();
        }

        #region Member
        public string FormState = "NEW";
        bool Success = true;
        public string Contract_ID = string.Empty;
        public string Room_ID = string.Empty;
        public string Renter_ID = string.Empty;
        string UnitID = string.Empty;
        int RowDtIndex = 0;
        SqlDataReader drTmp;
        ApartmentDB tblStatus = new ApartmentDB();
        ApartmentDB tblContract = new ApartmentDB();
        #endregion Member

        private void RunningNo()
        {
            int tmpAutoID = 0;
            string tmpQuoID = "";
            string tmpBrDate;
            string sqlTmp = string.Empty;


            sqlTmp = "";
            sqlTmp = "SELECT TOP 1 Contract_No FROM tblContract ORDER BY Contract_No DESC";

            try
            {
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;

                drTmp = dbConString.Com.ExecuteReader();
                drTmp.Read();
                tmpQuoID = drTmp["Contract_No"].ToString();
                tmpBrDate = tmpQuoID.Substring(7, 4);
                tmpAutoID = Convert.ToInt32(tmpBrDate) + 1;
                txtContractNo.Text = tmpAutoID.ToString("CON" + DateTime.Now.Year.ToString() + "0000");
                drTmp.Close();
            }
            catch
            {
                txtContractNo.Text = "CON" + DateTime.Now.Year.ToString() + "0001";
                drTmp.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void DoLoadForm()
        {
            LoadCombo();
            if (!string.IsNullOrEmpty(Contract_ID))
            {
                ShowData(Contract_ID);
            }
            else
            {
                RunningNo();
                dtpContractDate.Focus();
            }

        }

        protected override void DoReset()
        {
            Utilities.ResetAllControls(this);
            Contract_ID = string.Empty;
            Room_ID = string.Empty;
            Renter_ID = string.Empty;
        }

        protected override void DoSave()
        {
            Success = true;
            CheckData();

            if (Success)
            {
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
                            Contract_ID = Guid.NewGuid().ToString();
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();
                            string sqlTmp = string.Empty;
                            StringBd.Append(" INSERT INTO tblContract(Contract_ID, Renter_ID, Room_ID, Contract_No, Contract_Date, Contract_Recognizance, ");
                            StringBd.Append(" Contract_Status, Contract_Type, date_Checkin, date_Checkout, power_first, water_first, room_price) ");
                            StringBd.Append(" VALUES(@Contract_ID, @Renter_ID, @Room_ID, @Contract_No, @Contract_Date, @Contract_Recognizance, @Contract_Status,");
                            StringBd.Append(" @Contract_Type, @date_Checkin, @date_Checkout, @power_first, @water_first, @room_price) ");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();
                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = Contract_ID;
                            dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = Renter_ID;
                            dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = Room_ID;
                            dbConString.Com.Parameters.Add("@Contract_No", SqlDbType.VarChar).Value = txtContractNo.Text;
                            dbConString.Com.Parameters.Add("@Contract_Date", SqlDbType.DateTime).Value = dtpContractDate.Value;
                            dbConString.Com.Parameters.Add("@Contract_Recognizance", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRecognizance.Text);
                            dbConString.Com.Parameters.Add("@Contract_Status", SqlDbType.VarChar).Value = cboContractType.SelectedValue;
                            dbConString.Com.Parameters.Add("@Contract_Type", SqlDbType.VarChar).Value = cboContractType.SelectedValue;
                            dbConString.Com.Parameters.Add("@date_Checkin", SqlDbType.DateTime).Value = dtpcheckin.Value;
                            dbConString.Com.Parameters.Add("@date_Checkout", SqlDbType.DateTime).Value = dtpcheckout.Value;
                            dbConString.Com.Parameters.Add("@power_first", SqlDbType.VarChar).Value = txt_power_first.Text;
                            dbConString.Com.Parameters.Add("@water_first", SqlDbType.VarChar).Value = txt_water_first.Text;
                            dbConString.Com.Parameters.Add("@room_price", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_room_price.Text);
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
                else if (FormState == "EDIT")
                {
                    #region Edit
                    dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                    StringBuilder StringBd = new StringBuilder();
                    string sqlTmp = string.Empty;
                    StringBd.Append(" UPDATE tblContract SET Renter_ID = @Renter_ID, Room_ID = @Room_ID, Contract_No = @Contract_No, Contract_Date = @Contract_Date, ");
                    StringBd.Append(" Contract_Recognizance = @Contract_Recognizance, Contract_Status = @Contract_Status, Contract_Type = @Contract_Type, date_Checkin = @date_Checkin, ");
                    StringBd.Append(" date_Checkout = @date_Checkout, power_first = @power_first, water_first = @water_first, room_price = @room_price WHERE Contract_ID = @Contract_ID ");
                    sqlTmp = "";
                    sqlTmp = StringBd.ToString();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Transaction = dbConString.Transaction;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = Contract_ID;
                    dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = Renter_ID;
                    dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = Room_ID;
                    dbConString.Com.Parameters.Add("@Contract_No", SqlDbType.VarChar).Value = txtContractNo.Text;
                    dbConString.Com.Parameters.Add("@Contract_Date", SqlDbType.DateTime).Value = dtpContractDate.Value;
                    dbConString.Com.Parameters.Add("@Contract_Recognizance", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRecognizance.Text);
                    dbConString.Com.Parameters.Add("@Contract_Status", SqlDbType.VarChar).Value = cboContractType.SelectedValue;
                    dbConString.Com.Parameters.Add("@Contract_Type", SqlDbType.VarChar).Value = cboContractType.SelectedValue;
                    dbConString.Com.Parameters.Add("@date_Checkin", SqlDbType.DateTime).Value = dtpcheckin.Value;
                    dbConString.Com.Parameters.Add("@date_Checkout", SqlDbType.DateTime).Value = dtpcheckout.Value;
                    dbConString.Com.Parameters.Add("@power_first", SqlDbType.VarChar).Value = txt_power_first.Text;
                    dbConString.Com.Parameters.Add("@water_first", SqlDbType.VarChar).Value = txt_water_first.Text;
                    dbConString.Com.Parameters.Add("@room_price", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_room_price.Text);
                    dbConString.Com.ExecuteNonQuery();
                    dbConString.Transaction.Commit();
                    MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #endregion
                }
            }
        }

        private void ShowData(string Contract_ID)
        {
            if (!string.IsNullOrEmpty(Contract_ID))
            {
                #region Get data contract
                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblContract WHERE Contract_ID = '" + Contract_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = Contract_ID;
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tblContract.Clear();
                    da.Fill(tblContract, "tblContract");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                #endregion
               
            }

           
        }

        private void CheckData()
        {

            if(string.IsNullOrEmpty(Renter_ID))
            {
                MessageBox.Show("กรุณาเลือกผู้เช่า", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                btnAddRenter.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Room_ID))
            {
                MessageBox.Show("กรุณาเลือกห้องพัก", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                btnAddRoom.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtRecognizance.Text))
            {
                MessageBox.Show("กรุณากรอกเงินมัดจำ", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtRecognizance.Focus();
                return;
            }
        }

        private void LoadCombo()
        {
            #region ContractType
            try
            {

                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tblStatus WHERE StatusType = 'ContractType'";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblStatus.Clear();
                da.Fill(tblStatus, "tblStatus");
                da.Dispose();
                cboContractType.DataSource = tblStatus.tblStatus;
                cboContractType.DisplayMember = tblStatus.tblStatus.NameColumn.ColumnName;
                cboContractType.ValueMember = tblStatus.tblStatus.StatusIDColumn.ColumnName;
                cboContractType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }     

        private void txtRecognizance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmRoomSearch frmSearch = new frmRoomSearch();
            frmSearch.ShowDialog();

            txtRoom.Text = frmSearch.Room_Number;
            txtRoomType.Text = frmSearch.Room_Type;
            Room_ID = frmSearch.Room_ID;
        }

        private void btnAddRenter_Click(object sender, EventArgs e)
        {
            frmRenterSearch frmSearch = new frmRenterSearch();
            frmSearch.ShowDialog();
            txtRenterName.Text = frmSearch.Renter_Fullname;
            Renter_ID = frmSearch.Renter_ID;
        }

        private void txt_room_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
