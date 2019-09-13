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
using System.Globalization;

namespace ApartmentSmart
{
    public partial class frmRecord : BaseInfo
    {
        public frmRecord()
        {
            InitializeComponent();
        }

        #region Member
        public string FormState = "NEW";
        bool Success = true;
        ApartmentDB tblRecord = new ApartmentDB();
        public string Record_ID = string.Empty;
        #endregion Member

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void DoLoadForm()
        {
            if (!string.IsNullOrEmpty(Record_ID))
            {
                ShowData(Record_ID);
                cboMonth.Enabled = false;
                cboYear.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        protected override void DoReset()
        {

        }

        protected override void DoSave()
        {
            if (FormState == "NEW")
            {
                #region Save
                if (Success)
                {
                    try
                    {
                        Record_ID = Guid.NewGuid().ToString();
                        dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBuilder StringBd = new StringBuilder();
                        //dbConString.Transaction = new SqlTransaction();
                        string sqlTmp = string.Empty;
                        StringBd.Append("INSERT INTO tblRecord ");
                        StringBd.Append("VALUES (@Record_ID ,@Year ,@Month, (select StatusID from tblStatus where StatusType = 'RecordStatus' and name = 'บันทึกแล้วเรียบ')) ");
                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@Record_ID", SqlDbType.VarChar).Value = Record_ID;
                        dbConString.Com.Parameters.Add("@Year", SqlDbType.VarChar).Value = cboYear.Text;
                        dbConString.Com.Parameters.Add("@Month", SqlDbType.VarChar).Value = cboMonth.Text;
                        dbConString.Com.ExecuteNonQuery();
                        dbConString.Transaction.Commit();

                        foreach (ApartmentDB.uv_record_detailRow dr in tblRecord.uv_record_detail)
                        {
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tblRecordDT (RecordDT_ID,Record_ID,Contract_ID,Num_Water,Num_Power,Record_water,Before_Power,Record_power,Record_date)");
                            StringBd.Append(" VALUES (@RecordDT_ID,@Record_ID,@Contract_ID,@Num_Water,@Num_Power,@Record_water,@Before_Power,@Record_power,@Record_date)");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();
                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@RecordDT_ID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString();
                            dbConString.Com.Parameters.Add("@Record_ID", SqlDbType.VarChar).Value = Record_ID;
                            dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = dr.Contract_ID;
                            dbConString.Com.Parameters.Add("@Num_Water", SqlDbType.Float).Value = dr.Num_Water;
                            dbConString.Com.Parameters.Add("@Num_Power", SqlDbType.Float).Value = dr.Num_Power;
                            dbConString.Com.Parameters.Add("@Before_Power", SqlDbType.Float).Value = dr.Before_Power;
                            dbConString.Com.Parameters.Add("@Record_water", SqlDbType.Float).Value = dr.Record_water;
                            dbConString.Com.Parameters.Add("@Record_power", SqlDbType.Float).Value = dr.Record_power;
                            dbConString.Com.Parameters.Add("@Record_date", SqlDbType.DateTime).Value = DateTime.Now;
                            dbConString.Com.ExecuteNonQuery();
                            dbConString.Transaction.Commit();
                        }

                        MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSearch.Enabled = false;
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
            else if (FormState == "edit")
            {
                #region Edit
                if (Success)
                {
                    try
                    {

                        dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBuilder StringBd = new StringBuilder();
                        string sqlTmp = string.Empty;

                        #region Del DT
                        StringBd.Clear();
                        sqlTmp = string.Empty;
                        //dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBd.Append("DELETE tblRecordDT WHERE Record_ID = @Record_ID");
                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@Record_ID", SqlDbType.VarChar).Value = Record_ID;
                        dbConString.Com.ExecuteNonQuery();
                        //dbConString.Transaction.Commit();
                        #endregion


                        dgvRecordDT.RefreshEdit();
                        foreach (ApartmentDB.tblRecordDTRow dr in tblRecord.tblRecordDT)
                        {
                            //dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tblRecordDT (RecordDT_ID,Record_ID,Contract_ID,Num_Water,Num_Power,Record_water,Before_Power,Record_power,Record_date)");
                            StringBd.Append(" VALUES (@RecordDT_ID,@Record_ID,@Contract_ID,@Num_Water,@Num_Power,@Record_water,@Before_Power,@Record_power,@Record_date)");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();
                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@RecordDT_ID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString();
                            dbConString.Com.Parameters.Add("@Record_ID", SqlDbType.VarChar).Value = Record_ID;
                            dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = dr.Contract_ID;
                            dbConString.Com.Parameters.Add("@Num_Water", SqlDbType.Float).Value = dr.Num_Water;
                            dbConString.Com.Parameters.Add("@Before_Power", SqlDbType.Float).Value = dr.Before_Power;
                            dbConString.Com.Parameters.Add("@Num_Power", SqlDbType.Float).Value = dr.Num_Power;
                            dbConString.Com.Parameters.Add("@Record_water", SqlDbType.Float).Value = dr.Record_water;
                            dbConString.Com.Parameters.Add("@Record_power", SqlDbType.Float).Value = dr.Record_power;
                            dbConString.Com.Parameters.Add("@Record_date", SqlDbType.DateTime).Value = DateTime.Now;
                            dbConString.Com.ExecuteNonQuery();

                        }
                        dbConString.Transaction.Commit();

                        MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex < 0)
                return;

            if (cboMonth.SelectedIndex < 0)
                return;

            string sqlTmp = string.Empty;
            sqlTmp = " SELECT * FROM uv_contract c ";
            sqlTmp += " WHERE c.Contract_Type = (SELECT StatusID FROM tblStatus WHERE Name = 'รายเดือน')  ";
            sqlTmp += " AND c.Contract_Status = (SELECT StatusID FROM tblStatus WHERE Name = 'เข้าพัก' ) ";
            sqlTmp += " AND c.Date_Checkout > DATEFROMPARTS (" + (Convert.ToInt32(cboYear.Text) - 543) + ", " + GetMonthNumberByName(cboMonth.Text) + ", 01) ";

            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblRecord.Clear();
            da.Fill(tblRecord, "uv_contract");
            da.Dispose();

            foreach(ApartmentDB.uv_contractRow dr in tblRecord.uv_contract)
            {
                ApartmentDB.uv_record_detailRow drTemp = tblRecord.uv_record_detail.Newuv_record_detailRow();
                drTemp.RenterFullname = dr.RenterFullname;
                drTemp.Room_number = dr.Room_number;
                drTemp.Record_water = dbConString.Water;
                drTemp.Record_power = dbConString.Power;
                drTemp.Before_Power = Convert.ToDouble(dr.Room_MetersNo);
                drTemp.Contract_ID = dr.Contract_ID;
                tblRecord.uv_record_detail.Adduv_record_detailRow(drTemp);
                tblRecord.uv_record_detail.AcceptChanges();
            }

            dgvRecordDT.DataSource = tblRecord.uv_record_detail;
        }

        private void btnPostPayment_Click(object sender, EventArgs e)
        {
            foreach (ApartmentDB.uv_record_detailRow dr in tblRecord.uv_record_detail)
            {
                // Update Power in tbl Room
                updateBeforePowerRoom(dr.Contract_ID, dr.Num_Power);

                // Perpare Data Payment
                string PaymentID = Guid.NewGuid().ToString();
                StringBuilder StringBd = new StringBuilder();
                string sqlTmp = string.Empty;
                //Save Data
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBd = new StringBuilder();
                sqlTmp = string.Empty;
                StringBd.Append(" INSERT INTO tblPayment(Pay_ID, Contract_ID, Record_ID, Pay_Sum_amount, Pay_status) ");
                StringBd.Append(" VALUES(@Pay_ID, @Contract_ID, @Record_ID, @Pay_Sum_amount, (SELECT StatusID FROM tblStatus WHERE StatusType = 'PaymentStatus' AND Name = 'ค้างชำระ')); ");

                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = PaymentID;
                dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = dr.Contract_ID;
                dbConString.Com.Parameters.Add("@Record_ID", SqlDbType.VarChar).Value = Record_ID;
                dbConString.Com.Parameters.Add("@Pay_Sum_amount", SqlDbType.Decimal).Value = Convert.ToDecimal(((dr.Num_Power - dr.Before_Power) * dr.Record_power) + (dr.Num_Water * dr.Record_water)) + dr.room_price;
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
                dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = "ค่าห้องพัก เดือน" + dr.Month;
                dbConString.Com.Parameters.Add("@Amount", SqlDbType.Decimal).Value = dr.room_price;
                dbConString.Com.ExecuteNonQuery();

                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = PaymentID;
                dbConString.Com.Parameters.Add("@PayDT_ID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString(); ;
                dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = "ค่าไฟฟ้า เดือน" + dr.Month + " มิเตอร์ไฟฟ้า " + dr.Before_Power + " ถึง " + dr.Num_Power + " ใช้ไฟไป " + (dr.Num_Power - dr.Before_Power) + " หน่วย";
                dbConString.Com.Parameters.Add("@Amount", SqlDbType.Decimal).Value = ((dr.Num_Power - dr.Before_Power) * dr.Record_power);
                dbConString.Com.ExecuteNonQuery();

                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = PaymentID;
                dbConString.Com.Parameters.Add("@PayDT_ID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString(); ;
                dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = "ค่าน้ำปะปา เดือน " + dr.Month + " ใช้น้ำปะปา" + dr.Before_Power + " หน่วย";
                dbConString.Com.Parameters.Add("@Amount", SqlDbType.Decimal).Value = (dr.Num_Water * dr.Record_water);
                dbConString.Com.ExecuteNonQuery();

                dbConString.Transaction.Commit();
            }

            updateRecordPost(Record_ID);
            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPostPayment.Enabled = false;
        }

        private int GetMonthNumberByName(string monthName)
        {
            switch (monthName)
            {
                case "มกราคม": return 1;
                case "กุมภาพันธ์": return 2;
                case "มีนาคม": return 3;
                case "เมษายน": return 4;
                case "พฤษภาคม": return 5;
                case "มิถุนายน": return 6;
                case "กรกฎาคม": return 7;
                case "สิงหาคม": return 8;
                case "กันยายน": return 9;
                case "ตุลาคม": return 10;
                case "พฤศจิกายน": return 11;
                case "ธันวาคม": return 12;
                default: return 0;
            }
        }

        private void ShowData(string Record_ID)
        {
            if (!string.IsNullOrEmpty(Record_ID))
            {

                string sqlTmp = "";
                #region Get data contract
                try
                {
                    sqlTmp = "";
                    sqlTmp = "SELECT * FROM uv_record_detail WHERE Record_ID = '" + Record_ID   + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tblRecord.Clear();
                    da.Fill(tblRecord, "uv_record_detail");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                #endregion

                if (tblRecord.uv_record_detail.Rows.Count > 0)
                {
                    cboYear.Text = tblRecord.uv_record_detail[0].Year;
                    cboMonth.Text = tblRecord.uv_record_detail[0].Month;
                    dgvRecordDT.DataSource = tblRecord.uv_record_detail;

                    if (tblRecord.uv_record_detail[0].RecordStatus.Equals("69093347-B007-409A-8D86-6B9D44F1D990"))
                        btnPostPayment.Enabled = false;
                }                
            }


        }

        private void updateBeforePowerRoom(string Contract_ID, double before_power)
        {
            try
            {
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;
                StringBd.Append("UPDATE tblRoom SET Room_MetersNo = @before_power WHERE Room_ID = (SELECT Room_ID FROM tblContract WHERE Contract_ID = @Contract_ID);");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = Contract_ID;
                dbConString.Com.Parameters.Add("@before_power", SqlDbType.Float).Value = before_power;
                dbConString.Com.ExecuteNonQuery();
                dbConString.Transaction.Commit();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateRecordPost(string Record_ID)
        {
            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
            StringBuilder StringBd = new StringBuilder();
            //dbConString.Transaction = new SqlTransaction();
            string sqlTmp = string.Empty;
            StringBd.Append("UPDATE tblRecord SET RecordStatus = '69093347-B007-409A-8D86-6B9D44F1D990' WHERE Record_ID = @Record_ID");
            sqlTmp = "";
            sqlTmp = StringBd.ToString();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.Connection = dbConString.mySQLConn;
            dbConString.Com.Transaction = dbConString.Transaction;
            dbConString.Com.Parameters.Clear();
            dbConString.Com.Parameters.Add("@Record_ID", SqlDbType.VarChar).Value = Record_ID;
            dbConString.Com.ExecuteNonQuery();
            dbConString.Transaction.Commit();
        }
    }
}
