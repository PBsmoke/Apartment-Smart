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
        public string BillType = "D";
        public string Pay_ID = string.Empty;
        public string remake = string.Empty;

        private void frmrptPayment_Load(object sender, EventArgs e)
        {
            ReportDS tblReport = new ReportDS();
            if (BillType.Equals("D"))
            {
                dbConString.Chk_ConnectionState();
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM uv_payment_print WHERE Pay_ID = '" + Pay_ID + "'";
                rptReceipt fReportS = new rptReceipt();
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblReport.Clear();
                da.Fill(tblReport, "uv_payment_print");
                da.Dispose();
                MoneyExt mne = new MoneyExt();
                string xThaiWord = "";
                double xNet = Convert.ToDouble(tblReport.uv_payment_print[0].Pay_Sum_amount);
                xThaiWord = "(=" + mne.NumberToThaiWord(xNet) + "=)";

                fReportS.SetDataSource(tblReport);
                fReportS.SetParameterValue("NumberToThai", xThaiWord);
                fReportS.SetParameterValue("OrgName", dbConString.OrgName);
                fReportS.SetParameterValue("Address", dbConString.Address + " โทร. " + dbConString.Tel);

                crvShow.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController;
                crvShow.ReportSource = fReportS;
            }
            else
            {
                dbConString.Chk_ConnectionState();
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM uv_payment_print WHERE Pay_ID = '" + Pay_ID + "'";
                rptReceiptMonthly fReportS = new rptReceiptMonthly();
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblReport.Clear();
                da.Fill(tblReport, "uv_payment_print");
                da.Dispose();
                MoneyExt mne = new MoneyExt();
                string xThaiWord = "";
                double xNet = Convert.ToDouble(tblReport.uv_payment_print[0].Pay_Sum_amount);
                xThaiWord = "(=" + mne.NumberToThaiWord(xNet) + "=)";

                fReportS.SetDataSource(tblReport);
                fReportS.SetParameterValue("NumberToThai", xThaiWord);
                fReportS.SetParameterValue("OrgName", dbConString.OrgName);
                fReportS.SetParameterValue("Address", dbConString.Address + " โทร. " + dbConString.Tel);

                crvShow.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController;
                crvShow.ReportSource = fReportS;
            }
        }
    }
}
