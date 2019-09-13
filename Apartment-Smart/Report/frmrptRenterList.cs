using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ApartmentSmart.Class;
using ApartmentSmart.Data;
using ApartmentSmart.Report;

namespace ApartmentSmart
{
    public partial class frmrptRenterList : Form
    {
        public frmrptRenterList()
        {
            InitializeComponent();
        }

        public string ContractID = string.Empty;

        private void frmrptRenterList_Load(object sender, EventArgs e)
        {
            ReportDS tblReport = new ReportDS();
            dbConString.Chk_ConnectionState();
            rptRenterList fReportS = new rptRenterList();

            string sqlTmp = "";
            sqlTmp = "SELECT * FROM uv_renter";
            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblReport.Clear();
            da.Fill(tblReport, "uv_renter");
            da.Dispose();
            fReportS.SetDataSource(tblReport);
            fReportS.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            crvShow.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController;
            crvShow.ReportSource = fReportS;
        }
    }
}
