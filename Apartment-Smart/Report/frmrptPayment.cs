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
    public partial class frmrptPayment : Form
    {
        public frmrptPayment()
        {
            InitializeComponent();
        }
        public string BillType = "fullbill";
        public string SaleID = string.Empty;
        public string remake = string.Empty;

        private void frmrptContract_Load(object sender, EventArgs e)
        {
            ApartmentDB tblReport = new ApartmentDB();
            dbConString.Chk_ConnectionState();

            string sqlTmp = "";
            sqlTmp = "SELECT * FROM uv_Sale WHERE SaleID = '" + SaleID + "'";
            rptContract fReportS = new rptContract();
            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblReport.Clear();
            da.Fill(tblReport, "uv_Sale");
            da.Dispose();
            MoneyExt mne = new MoneyExt();
            string xThaiWord = "";
            double xNet = 0; // Convert.ToDouble(tblReport.uv_Sale[0].SumTotal);
            xThaiWord = "(=" + mne.NumberToThaiWord(xNet) + "=)";

            fReportS.SetDataSource(tblReport);
            fReportS.SetParameterValue("NumberToThai", xThaiWord);
            fReportS.SetParameterValue("OrgName", dbConString.OrgName);
            fReportS.SetParameterValue("Address", dbConString.Address + " โทร. " + dbConString.Tel);
            if (dbConString.TaxRate > 0)
            {
                fReportS.SetParameterValue("TaxID", "เลขประจำตัวผู้เสียภาษี : " + dbConString.TaxID);
            } else
            {
                fReportS.SetParameterValue("TaxID", "");
            }



            //fReportS.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)RawKindTmp;
            fReportS.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            crvShow.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController;
            crvShow.ReportSource = fReportS;
        }
    }
}
