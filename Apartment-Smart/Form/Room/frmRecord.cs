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
            loadCombo();
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
                        dbConString.Com.Parameters.Add("@Year", SqlDbType.VarChar).Value = cboYear.SelectedValue;
                        dbConString.Com.Parameters.Add("@Month", SqlDbType.VarChar).Value = cboMonth.SelectedValue;
                        dbConString.Com.ExecuteNonQuery();
                        dbConString.Transaction.Commit();

                        foreach (ApartmentDB.tblRecordDTRow dr in tblRecord.tblRecordDT)
                        {
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tblRecordDT (RecordDT_ID,Record_ID,Renter_ID,Room_ID,Num_Water,Num_Power,Record_water,Record_power,Record_date)");
                            StringBd.Append(" VALUES (@RecordDT_ID,@Record_ID,@Renter_ID,@Room_ID,@Num_Water,@Num_Power,@Record_water,@Record_power,@Record_date)");
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
                            dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = dr.Renter_ID;
                            dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = dr.Room_ID;
                            dbConString.Com.Parameters.Add("@Num_Water", SqlDbType.Float).Value = dr.Num_Water;
                            dbConString.Com.Parameters.Add("@Num_Power", SqlDbType.Float).Value = dr.Num_Power;
                            dbConString.Com.Parameters.Add("@Record_water", SqlDbType.Float).Value = dr.Record_water;
                            dbConString.Com.Parameters.Add("@Record_power", SqlDbType.Float).Value = dr.Record_power;
                            dbConString.Com.Parameters.Add("@Record_date", SqlDbType.DateTime).Value = DateTime.Now;
                            dbConString.Com.ExecuteNonQuery();
                            dbConString.Transaction.Commit();
                        }

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
                            StringBd.Append("INSERT INTO tblRecordDT (RecordDT_ID,Record_ID,Renter_ID,Room_ID,Num_Water,Num_Power,Record_water,Record_power,Record_date)");
                            StringBd.Append(" VALUES (@RecordDT_ID,@Record_ID,@Renter_ID,@Room_ID,@Num_Water,@Num_Power,@Record_water,@Record_power,Record_date)");
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
                            dbConString.Com.Parameters.Add("@Renter_ID", SqlDbType.VarChar).Value = dr.Renter_ID;
                            dbConString.Com.Parameters.Add("@Room_ID", SqlDbType.VarChar).Value = dr.Room_ID;
                            dbConString.Com.Parameters.Add("@Num_Water", SqlDbType.Float).Value = dr.Num_Water;
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
            sqlTmp = " select ";
            sqlTmp += " recDT.Record_ID, ";
            sqlTmp += " ISNULL(recDT.RecordDT_ID,'') AS RecordDT_ID, ";
            sqlTmp += " ISNULL(recDT.Num_Power, 0) AS Num_Power, ";
            sqlTmp += " ISNULL(recDT.Num_Water, 0) AS Num_Water, ";
            sqlTmp += " recDT.Record_date, ";
            sqlTmp += " rent.Renter_TitleName + ' ' + rent.Renter_Name + ' ' + rent.Renter_Lastname AS Renter_Name, ";
            sqlTmp += " rent.Renter_ID, ";
            sqlTmp += " r.Room_number AS Room_Number, ";
            sqlTmp += " r.Room_ID AS Room_ID, ";
            sqlTmp += " 0 AS Record_water, ";
            sqlTmp += " 0 AS Record_power ";
            sqlTmp += " FROM tblRenter rent ";
            sqlTmp += " LEFT OUTER JOIN tblRecordDT recDT on recDT.Renter_ID = rent.Renter_ID ";
            sqlTmp += " LEFT OUTER JOIN tblRecord rec on rec.Record_ID = recDT.Record_ID ";
            sqlTmp += " LEFT JOIN tblContract c on c.Renter_ID = rent.Renter_ID ";
            sqlTmp += " INNER JOIN tblRoom r on c.Room_ID = r.Room_ID ";
            sqlTmp += " WHERE c.Contract_Type = (select StatusID from tblStatus where Name = 'รายเดือน') ";

            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblRecord.Clear();
            da.Fill(tblRecord, "tblRecordDT");
            da.Dispose();
            dgvRecordDT.DataSource = tblRecord.tblRecordDT;
        }

        private void loadCombo()
        {
            cboMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
                                         .MonthNames.Take(12).ToList();
            cboMonth.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames[DateTime.Now.AddMonths(-1).Month - 1];

            cboYear.DataSource = Enumerable.Range(2019, DateTime.Now.Year - 2019 + 1).ToList();
            cboYear.SelectedItem = DateTime.Now.Year;
        }
    }
}
