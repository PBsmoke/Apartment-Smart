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
using ApartmentSmart.Report;

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
        ApartmentDB tblStatus2 = new ApartmentDB();
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

                if(cboStatus.Text.Equals("หมดสัญญา"))
                    Utilities.EnableAllControls(this);
            }
            else
            {
                RunningNo();
                cboStatus.Enabled = false;
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
                            StringBd.Append(" Contract_Status, Contract_Type, date_Checkin, date_Checkout, power_first, water_first, room_price, Remark) ");
                            StringBd.Append(" VALUES(@Contract_ID, @Renter_ID, @Room_ID, @Contract_No, @Contract_Date, @Contract_Recognizance, (select StatusID from tblStatus where Name = 'มัดจำ' and StatusType = 'ContractStatus'),");
                            StringBd.Append(" @Contract_Type, @date_Checkin, @date_Checkout, @power_first, @water_first, @room_price, @Remark) ");
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
                            dbConString.Com.Parameters.Add("@Contract_Status", SqlDbType.VarChar).Value = cboStatus.SelectedValue;
                            dbConString.Com.Parameters.Add("@Contract_Type", SqlDbType.VarChar).Value = cboContractType.SelectedValue;
                            dbConString.Com.Parameters.Add("@date_Checkin", SqlDbType.DateTime).Value = dtpcheckin.Value;
                            dbConString.Com.Parameters.Add("@date_Checkout", SqlDbType.DateTime).Value = ((cboContractType.Text.Equals("รายเดือน")) ? DateTime.MaxValue.AddYears(-100) : dtpcheckout.Value); 
                            dbConString.Com.Parameters.Add("@power_first", SqlDbType.VarChar).Value = txt_power_first.Text;
                            dbConString.Com.Parameters.Add("@water_first", SqlDbType.VarChar).Value = txt_water_first.Text;
                            dbConString.Com.Parameters.Add("@room_price", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_room_price.Text);
                            dbConString.Com.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text;

                            dbConString.Com.ExecuteNonQuery();
                            dbConString.Transaction.Commit();
                            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboStatus.Enabled = true;
                            FormState = "EDIT";
                        }
                        catch (Exception ex)
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
                    StringBd.Append(" date_Checkout = @date_Checkout, power_first = @power_first, water_first = @water_first, room_price = @room_price, Remark = @Remark WHERE Contract_ID = @Contract_ID ");

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
                    dbConString.Com.Parameters.Add("@Contract_Status", SqlDbType.VarChar).Value = cboStatus.SelectedValue;
                    dbConString.Com.Parameters.Add("@Contract_Type", SqlDbType.VarChar).Value = cboContractType.SelectedValue;
                    dbConString.Com.Parameters.Add("@date_Checkin", SqlDbType.DateTime).Value = dtpcheckin.Value;
                    dbConString.Com.Parameters.Add("@date_Checkout", SqlDbType.DateTime).Value = ((cboContractType.Text.Equals("รายเดือน")) ? DateTime.MaxValue.AddYears(-10) : dtpcheckout.Value);
                    dbConString.Com.Parameters.Add("@power_first", SqlDbType.VarChar).Value = txt_power_first.Text;
                    dbConString.Com.Parameters.Add("@water_first", SqlDbType.VarChar).Value = txt_water_first.Text;
                    dbConString.Com.Parameters.Add("@room_price", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_room_price.Text);
                    dbConString.Com.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text;

                    dbConString.Com.ExecuteNonQuery();
                    dbConString.Transaction.Commit();

                    if (cboStatus.Text.Equals("เข้าพัก")) {

                        // Update Status Room 
                        updateStatusRoom(Room_ID, "ไม่ว่าง");

                    }
                    else if (cboStatus.Text.Equals("หมดสัญญา"))
                    {
                        // Update Status Room 
                        updateStatusRoom(Room_ID, "ว่าง");

                        // Save Payment รายวัน
                        if (cboContractType.Text.Equals("รายวัน"))
                        {
                            // Perpare Data Payment
                            double numDay = 0;
                            double priceRoom = Convert.ToDouble(txt_room_price.Text);
                            DateTime d1 = dtpcheckin.Value;
                            DateTime d2 = dtpcheckout.Value;
                            TimeSpan diffResult = d2.Date.Subtract(d1.Date);
                            numDay = diffResult.Days;
                            string PaymentID = Guid.NewGuid().ToString();

                            //Save Data
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBd = new StringBuilder();
                            sqlTmp = string.Empty;
                            StringBd.Append(" INSERT INTO tblPayment(Pay_ID, Contract_ID, Pay_Sum_amount, Pay_status) ");
                            StringBd.Append(" VALUES(@Pay_ID, @Contract_ID, @Pay_Sum_amount, (SELECT StatusID FROM tblStatus WHERE StatusType = 'PaymentStatus' AND Name = 'ค้างชำระ')); ");

                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();
                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = PaymentID;
                            dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = Contract_ID;
                            dbConString.Com.Parameters.Add("@Pay_Sum_amount", SqlDbType.Decimal).Value = (priceRoom * numDay); 
                            dbConString.Com.ExecuteNonQuery();

                            StringBd = new StringBuilder();
                            sqlTmp = string.Empty;
                            StringBd.Append(" INSERT INTO tblPaymentDT(PayDT_ID, Pay_ID, Detail, Amount) ");
                            StringBd.Append(" VALUES(@PayDT_ID, @Pay_ID, @Detail, @Amount) ");

                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();
                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = PaymentID;
                            dbConString.Com.Parameters.Add("@PayDT_ID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString(); ;
                            dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = "ค่าห้องพัก";
                            dbConString.Com.Parameters.Add("@Amount", SqlDbType.Decimal).Value = (priceRoom * numDay);
                            dbConString.Com.ExecuteNonQuery();

                            dbConString.Transaction.Commit();
                        }
                    }

                    MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #endregion
                }
            }
        }

        private void ShowData(string Contract_ID)
        {
            if (!string.IsNullOrEmpty(Contract_ID))
            {

                string sqlTmp = "";
                #region Get data contract
                try
                {
                    sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblContract WHERE Contract_ID = '" + Contract_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
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

                if (tblContract.tblContract.Rows.Count > 0)
                {
                    txtContractNo.Text = tblContract.tblContract[0].Contract_No;
                    dtpContractDate.Value = tblContract.tblContract[0].Contract_Date;
                    txtRecognizance.Text = tblContract.tblContract[0].Contract_Recognizance.ToString("###0.00");
                    txt_room_price.Text = tblContract.tblContract[0].room_price.ToString("###0.00");
                    cboContractType.SelectedValue = tblContract.tblContract[0].Contract_Type;
                    cboStatus.SelectedValue = tblContract.tblContract[0].Contract_Status;
                    dtpcheckin.Value = tblContract.tblContract[0].Date_Checkin;
                    dtpcheckout.Value = tblContract.tblContract[0].Date_Checkout;
                    txt_power_first.Text = tblContract.tblContract[0].power_first.ToString("###0");
                    txt_water_first.Text = tblContract.tblContract[0].water_first.ToString("###0");
                    txtRemark.Text = tblContract.tblContract[0].Remark;
                    Room_ID = tblContract.tblContract[0].Room_ID;
                    Renter_ID = tblContract.tblContract[0].Renter_ID;

                    sqlTmp = "";
                    sqlTmp = "select r.Room_ID,	r.Room_number, r.Room_floor, s.Name AS Room_Type, r.Room_Price_daily, r.Room_Price_monthly, ";
                    sqlTmp += "	r.Room_status, r.Room_MetersNo, r.Room_Remark from tblRoom r INNER JOIN tblStatus s ON r.Room_Type = s.StatusID ";
                    sqlTmp += " WHERE Room_ID = '" + Room_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tblContract, "tblRoom");
                    da.Dispose();

                    if (tblContract.tblRoom.Count > 0)
                    {
                        txtRoom.Text = tblContract.tblRoom[0].Room_number;
                        txtRoomType.Text = tblContract.tblRoom[0].Room_Type;
                        txtPrice_daily.Text = tblContract.tblRoom[0].Room_Price_daily.ToString("###0.00");
                        txtPrice_monthly.Text = tblContract.tblRoom[0].Room_Price_monthly.ToString("###0.00");
                    }

                    sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblRenter WHERE Renter_ID = '" + Renter_ID + "'";
                    Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(tblContract, "tblRenter");
                    da.Dispose();

                    if (tblContract.tblRenter.Count > 0)
                    {
                        string Renter_TitleName = tblContract.tblRenter[0].Renter_TitleName;
                        string Renter_Name = tblContract.tblRenter[0].Renter_Name;
                        string Renter_LastName = tblContract.tblRenter[0].Renter_Lastname;
                        txtRenterName.Text = Renter_TitleName + " " + Renter_Name + " " + Renter_LastName;
                    }
                }

                if (cboContractType.Text.Equals("รายวัน"))
                {
                    dtpcheckout.Visible = true;
                    lblcheckout.Visible = true;
                }
                else
                {
                    dtpcheckout.Visible = false;
                    lblcheckout.Visible = false;
                }
            }


        }

        private void CheckData()
        {

            if (string.IsNullOrEmpty(Renter_ID))
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

            #region ContractStatus
            try
            {

                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tblStatus WHERE StatusType = 'ContractStatus'";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblStatus2.Clear();
                da.Fill(tblStatus2, "tblStatus");
                da.Dispose();
                cboStatus.DataSource = tblStatus2.tblStatus;
                cboStatus.DisplayMember = tblStatus2.tblStatus.NameColumn.ColumnName;
                cboStatus.ValueMember = tblStatus2.tblStatus.StatusIDColumn.ColumnName;
                cboStatus.SelectedIndex = 0;
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
            txtPrice_daily.Text = frmSearch.Price_daily.ToString("###0.00");
            txtPrice_monthly.Text = frmSearch.Price_monthly.ToString("###0.00");
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

        private void cboContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboContractType.Text.Equals("รายวัน"))
            {
                dtpcheckout.Visible = true;
                lblcheckout.Visible = true;
            }
            else
            {
                dtpcheckout.Visible = false;
                lblcheckout.Visible = false;
            }
        }

        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            frmrptContract form = new frmrptContract();
            form.ContractID = Contract_ID;
            form.ShowDialog();
        }

        private void updateStatusRoom(string Room_ID, string Room_Status)
        {
            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
            StringBuilder StringBd = new StringBuilder();
            //dbConString.Transaction = new SqlTransaction();
            string sqlTmp = string.Empty;
            StringBd.Append("UPDATE tblRoom SET Room_status = (SELECT  StatusID FROM tblStatus WHERE StatusType = 'RoomStatus' AND Name = @RoomStatus) WHERE Room_ID = @Room_ID;");
            sqlTmp = "";
            sqlTmp = StringBd.ToString();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.Connection = dbConString.mySQLConn;
            dbConString.Com.Transaction = dbConString.Transaction;
            dbConString.Com.Parameters.Clear();
            dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = Room_ID;
            dbConString.Com.Parameters.Add("@RoomStatus", SqlDbType.VarChar).Value = Room_Status;
            dbConString.Com.ExecuteNonQuery();
            dbConString.Transaction.Commit();
        }
    }
}
