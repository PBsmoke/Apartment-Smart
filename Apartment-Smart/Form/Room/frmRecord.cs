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
        ApartmentDB tblRecord = new ApartmentDB();
        public string Record_ID = string.Empty;
        #endregion Member

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        protected override void DoLoadForm()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
            cboMonth.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
                                                     .MonthNames.Take(12).ToList();
            cboMonth.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
                                                    .MonthNames[DateTime.Now.AddMonths(-1).Month - 1];

            cboYear.DataSource = Enumerable.Range(2019, DateTime.Now.Year - 2019 + 1).ToList();
            cboYear.SelectedItem = DateTime.Now.Year;
        }

        protected override void DoReset()
        {
            
        }

        protected override void DoSave()
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            string sqlTmp = string.Empty;

            sqlTmp = " select c.Renter_ID,r.Room_number AS Room_ID,0 AS Num_Water,0 AS Num_Power,o.Record_power,o.Record_water from tblOwner o, tblContract c ";
            sqlTmp += " INNER JOIN tblRoom r on c.Room_ID = r.Room_ID ";
            sqlTmp += " where c.Contract_Type = (select StatusID from tblStatus where Name = 'รายเดือน') ";


            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblRecord.Clear();
            da.Fill(tblRecord, "tblRecord");
            da.Dispose();
            dgvShow.DataSource = tblRecord.tblRecord;
        }
    }
}
