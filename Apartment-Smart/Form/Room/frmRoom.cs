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
    public partial class frmRoom : BaseInfo
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        #region Member
        public string FormState = "NEW";
        bool Success = true;
        public string Room_ID = string.Empty;
        string RoomID = string.Empty;
        ApartmentDB tblRoom = new ApartmentDB();
        ApartmentDB tblStatus = new ApartmentDB();
        SqlDataReader drTmp;
        #endregion Member

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void DoLoadForm()
        {
            SetDefaultData();
            LoadCombo();
            if (!string.IsNullOrEmpty(Room_ID))
            {
                ShowData(Room_ID);
            }
            else
            {
                txtRoom_floor.Focus();
            }

        }

        protected override void DoReset()
        {
            Utilities.ResetAllControls(this);
            Room_ID = string.Empty;
            SetDefaultData();
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
                        Room_ID = Guid.NewGuid().ToString();
                        dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBuilder StringBd = new StringBuilder();
                        string sqlTmp = string.Empty;
                        StringBd.Append("INSERT INTO tblRoom(Room_ID, Room_number, Room_floor, Room_Type, Room_Price_daily, Room_Price_monthly, Room_MetersNo, Room_Remark, Room_status) ");
                        StringBd.Append("VALUES(@Room_ID, @Room_number, @Room_floor, @Room_Type, @Room_Price_daily, @Room_Price_monthly, @Room_MetersNo, @Room_Remark, (select StatusID from tblStatus where Name = 'ว่าง')) ");
                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = Room_ID;
                        dbConString.Com.Parameters.Add("@Room_number", SqlDbType.VarChar).Value = txtRoom_number.Text;
                        dbConString.Com.Parameters.Add("@Room_floor", SqlDbType.VarChar).Value = txtRoom_floor.Text;
                        dbConString.Com.Parameters.Add("@Room_Type", SqlDbType.VarChar).Value = cboRoomType.SelectedValue;
                        dbConString.Com.Parameters.Add("@Room_Price_daily", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice_daily.Text);
                        dbConString.Com.Parameters.Add("@Room_Price_monthly", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice_monthly.Text);
                        dbConString.Com.Parameters.Add("@Room_MetersNo", SqlDbType.VarChar).Value = txtMetersNo.Text;
                        dbConString.Com.Parameters.Add("@Room_Remark", SqlDbType.VarChar).Value = txtRemark.Text;
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
                        //dbConString.Transaction = new SqlTransaction();
                        string sqlTmp = string.Empty;
                        StringBd.Append("UPDATE tblRoom SET Room_number = @Room_number, Room_floor = @Room_floor, Room_Type = @Room_Type, ");
                        StringBd.Append(" Room_Price_daily = @Room_Price_daily, Room_Price_monthly = @Room_Price_monthly, Room_MetersNo = @Room_MetersNo, ");
                        StringBd.Append(" Room_Remark = @Room_Remark WHERE Room_ID = @Room_ID");
                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = Room_ID;
                        dbConString.Com.Parameters.Add("@Room_number", SqlDbType.VarChar).Value = txtRoom_number.Text;
                        dbConString.Com.Parameters.Add("@Room_floor", SqlDbType.VarChar).Value = txtRoom_floor.Text;
                        dbConString.Com.Parameters.Add("@Room_Type", SqlDbType.VarChar).Value = cboRoomType.SelectedValue;
                        dbConString.Com.Parameters.Add("@Room_Price_daily", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice_daily.Text);
                        dbConString.Com.Parameters.Add("@Room_Price_monthly", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice_monthly.Text);
                        dbConString.Com.Parameters.Add("@Room_MetersNo", SqlDbType.VarChar).Value = txtMetersNo.Text;
                        dbConString.Com.Parameters.Add("@Room_Remark", SqlDbType.VarChar).Value = txtRemark.Text;
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

        private void ShowData(string Room_ID)
        {
            if (!string.IsNullOrEmpty(Room_ID))
            {
                #region Room Data
                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblRoom WHERE Room_ID = '" + Room_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = Room_ID;
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tblRoom.Clear();
                    da.Fill(tblRoom, "tblRoom");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                #endregion

                if (tblRoom.tblRoom.Rows.Count > 0)
                {
                    txtRoom_number.Text = tblRoom.tblRoom[0].Room_number;
                    txtRoom_floor.Text = tblRoom.tblRoom[0].Room_floor;
                    cboRoomType.SelectedValue = tblRoom.tblRoom[0].Room_Type;
                    txtPrice_daily.Text = tblRoom.tblRoom[0].Room_Price_daily.ToString("###0.00");
                    txtPrice_monthly.Text = tblRoom.tblRoom[0].Room_Price_monthly.ToString("###0.00");
                    txtMetersNo.Text = tblRoom.tblRoom[0].Room_MetersNo;
                    txtRemark.Text = tblRoom.tblRoom[0].Room_Remark;
                }
            }           
        }

        private void CheckData()
        {
            if (string.IsNullOrEmpty(txtRoom_number.Text))
            {
                MessageBox.Show("กรุณากรอกเลขที่ห้อง", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtRoom_floor.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtRoom_floor.Text))
            {
                MessageBox.Show("กรุณากรอกชั้น", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtRoom_floor.Focus();
                return;
            }            
        }

        private void SetDefaultData()
        { 
            txtPrice_daily.Text = "0.00";
            txtPrice_monthly.Text = "0.00";
        }

        private void LoadCombo()
        {
            #region ProductType
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tblStatus WHERE StatusType = 'RoomType'";
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
                cboRoomType.DataSource = tblStatus.tblStatus;
                cboRoomType.DisplayMember = tblStatus.tblStatus.NameColumn.ColumnName;
                cboRoomType.ValueMember = tblStatus.tblStatus.StatusIDColumn.ColumnName;

                cboRoomType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        private void txtPrice_monthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_daily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
