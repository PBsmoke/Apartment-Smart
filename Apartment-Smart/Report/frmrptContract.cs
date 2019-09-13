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
    public partial class frmrptContract : Form
    {
        public frmrptContract()
        {
            InitializeComponent();
        }

        public string ContractID = string.Empty;

        private void frmrptContract_Load(object sender, EventArgs e)
        {
            ReportDS tblReport = new ReportDS();
            dbConString.Chk_ConnectionState();
            rptContract fReportS = new rptContract();

            string sqlTmp = "";
            sqlTmp = "SELECT * FROM uv_contract WHERE Contract_ID = '" + ContractID + "'";
            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblReport.Clear();
            da.Fill(tblReport, "uv_contract");
            da.Dispose();
            MoneyExt mne = new MoneyExt();
            string RecognizaNumberToThai = "";
            string RoomPrice = "";
            double xNet = Convert.ToDouble(tblReport.uv_contract[0].Contract_Recognizance);
            RecognizaNumberToThai = mne.NumberToThaiWord(xNet);
            xNet = Convert.ToDouble(tblReport.uv_contract[0].room_price);
            RoomPrice = mne.NumberToThaiWord(xNet);

            fReportS.SetDataSource(tblReport);
            fReportS.SetParameterValue("RecognizaNumberToThai", RecognizaNumberToThai);
            fReportS.SetParameterValue("RoomPriceToThai", RoomPrice);
            fReportS.SetParameterValue("OrgName", dbConString.OrgName);
            fReportS.SetParameterValue("Water", dbConString.Water);
            fReportS.SetParameterValue("Power", dbConString.Power);

            fReportS.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            crvShow.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController;
            crvShow.ReportSource = fReportS;
        }
    }
}
