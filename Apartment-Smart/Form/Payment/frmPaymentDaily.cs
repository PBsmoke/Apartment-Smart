using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ApartmentSmart.Class;
using ApartmentSmart.Data;

namespace ApartmentSmart
{
    public partial class frmPaymentDaily : BaseInfo
    {
        public frmPaymentDaily()
        {
            InitializeComponent();
        }


        #region Member
        public string Payment_ID = string.Empty;
        private string Contract_TypeName = "";
        ApartmentDB tblPayment = new ApartmentDB();
        int RowIndex = 0;
        #endregion Member

        protected override void DoLoadForm()
        {
            ShowData(Payment_ID);
            btnDel.Enabled = false;
            DoVisibleClear(false);
            btnPrint.Enabled = true;
        }

        private void ShowData(string Payment_ID)
        {
            if (!string.IsNullOrEmpty(Payment_ID))
            {

                string sqlTmp = "";
                #region Get data Payment HD
                try
                {
                    sqlTmp = "";
                    sqlTmp = "SELECT * FROM uv_payment WHERE Pay_ID = '" + Payment_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tblPayment.Clear();
                    da.Fill(tblPayment, "uv_payment");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                #endregion

                #region Get data Payment DT
                try
                {
                    sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblPaymentDT WHERE Pay_ID = '" + Payment_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tblPayment, "tblPaymentDT");
                    da.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                #endregion

                //Prepare data 
                if (tblPayment.uv_payment.Rows.Count > 0)
                {
                    txtRenterName.Text = tblPayment.uv_payment[0].RenterFullname;
                    txtContractNo.Text = tblPayment.uv_payment[0].Contract_No;
                    DateTime d1 = tblPayment.uv_payment[0].Date_Checkin;
                    DateTime d2 = tblPayment.uv_payment[0].Date_Checkout;
                    TimeSpan diffResult = d2.Date.Subtract(d1.Date);
                    txtDateCheckIn.Text = d1.Date.ToShortDateString();
                    txtDateCheckOut.Text = d2.Date.ToShortDateString();
                    txtNumberDay.Text = diffResult.Days.ToString();
                    txtRoomNo.Text = tblPayment.uv_payment[0].Room_number;
                    txtRoomfloor.Text = tblPayment.uv_payment[0].Room_floor;
                    txtRecognizance.Text = tblPayment.uv_payment[0].Contract_Recognizance.ToString("###0.00");
                    txtStatus.Text = tblPayment.uv_payment[0].PaymentStatus;
                    dgvPaymentDetail.DataSource = tblPayment.tblPaymentDT;
                    Contract_TypeName = tblPayment.uv_payment[0].Contract_TypeName;

                    if (Contract_TypeName.Equals("รายเดือน"))
                    {
                        txtDateCheckOut.Visible = true;
                        txtNumberDay.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                    }

                    SumPrice();

                    if (txtStatus.Text.Equals("ชำระเรียบร้อย"))
                    {
                        Utilities.EnableAllControls(this);
                    }
                }
            }
        }

        private void SumPrice()
        {
            decimal SumPrice = 0.00M;
            foreach (ApartmentDB.tblPaymentDTRow dr in tblPayment.tblPaymentDT)
            {
                SumPrice += dr.Amount;
            }
            lblNet.Text = SumPrice.ToString("#,##0.00");
        }

        private void dgvPaymentDetail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RowIndex = e.RowIndex;
            txtDetail.Text = tblPayment.tblPaymentDT[RowIndex].Detail;
            txtAmount.Text = tblPayment.tblPaymentDT[RowIndex].Amount.ToString("###0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDetail.Text))
            {
                MessageBox.Show("กรุณาระบุรายละเอียด", "คำเตือน", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("กรุณาระบุราคา", "คำเตือน", MessageBoxButtons.OK);
                return;
            }

            ApartmentDB.tblPaymentDTRow[] drTmp = (ApartmentDB.tblPaymentDTRow[])tblPayment.tblPaymentDT.Select("Detail = '" + txtDetail.Text + "'");

            if (drTmp.Length > 0)
            {
                drTmp[0].Amount = Convert.ToDecimal(txtAmount.Text);
            }
            else
            {
                ApartmentDB.tblPaymentDTRow dr = tblPayment.tblPaymentDT.NewtblPaymentDTRow();
                dr.Detail = txtDetail.Text;
                dr.Amount = Convert.ToDecimal(txtAmount.Text);
                tblPayment.tblPaymentDT.AddtblPaymentDTRow(dr);
                dgvPaymentDetail.DataSource = tblPayment;
                dgvPaymentDetail.DataMember = tblPayment.tblPaymentDT.TableName;
                dgvPaymentDetail.Refresh();
                SumPrice();
            }
            #region

            txtDetail.Text = string.Empty;
            txtAmount.Text = string.Empty;

            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            #endregion
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tblPayment.tblPaymentDT.Rows.Count > 0)
            {
                tblPayment.tblPaymentDT[RowIndex].Delete();
                tblPayment.tblPayment.AcceptChanges();
                dgvPaymentDetail.DataSource = tblPayment;
                dgvPaymentDetail.DataMember = tblPayment.tblPaymentDT.TableName;
                dgvPaymentDetail.Refresh();
                SumPrice();
            }

            if (tblPayment.tblPaymentDT.Rows.Count == 0)
            {
                btnDel.Enabled = false;
            }
            else
            {
                btnDel.Enabled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDetail.Clear();
            txtAmount.Clear();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการบันทึกรายการชำระเงิน ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            #region Save
            string SaleID = Guid.NewGuid().ToString();
            try
            {
                #region HD
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;

                // Status = 0 : Cash
                // Status = 1 : Credit
                //PerPare Data


                StringBd.Clear();

                StringBd.Append("UPDATE tblPayment SET UserID = @UserID , Pay_Sum_amount = @Pay_Sum_amount, Pay_date = GETDATE(), Pay_status = (SELECT StatusID FROM tblStatus WHERE StatusType = 'PaymentStatus' AND Name = 'ชำระเรียบร้อย') WHERE Pay_ID = @Pay_ID;");
                StringBd.Append("DELETE tblPaymentDT WHERE Pay_ID = @Pay_ID;");


                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = Payment_ID;
                dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = dbConString.UserID;
                dbConString.Com.Parameters.Add("@Pay_Sum_amount", SqlDbType.VarChar).Value = Convert.ToDecimal(lblNet.Text);
                dbConString.Com.ExecuteNonQuery();
                dbConString.Transaction.Commit();
                #endregion

                #region DT
                foreach (ApartmentDB.tblPaymentDTRow dr in tblPayment.tblPaymentDT)
                {
                    dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                    StringBd.Clear();
                    StringBd.Append("INSERT INTO tblPaymentDT (PayDT_ID,Pay_ID,Detail,Amount) ");
                    StringBd.Append("VALUES (@PayDT_ID,@Pay_ID,@Detail,@Amount) ");

                    sqlTmp = "";
                    sqlTmp = StringBd.ToString();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Transaction = dbConString.Transaction;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@PayDT_ID", SqlDbType.VarChar).Value = Guid.NewGuid().ToString();
                    dbConString.Com.Parameters.Add("@Pay_ID", SqlDbType.VarChar).Value = Payment_ID;
                    dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = dr.Detail;
                    dbConString.Com.Parameters.Add("@Amount", SqlDbType.Decimal).Value = dr.Amount;
                    dbConString.Com.ExecuteNonQuery();
                    dbConString.Transaction.Commit();
                }
                #endregion

                MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                dbConString.Transaction.Rollback();
                return;
            }
            #endregion
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmrptPayment form = new frmrptPayment();
            form.Pay_ID = Payment_ID;
            if (Contract_TypeName.Equals("รายเดือน"))
            {
                form.BillType = "M";
            }
            form.ShowDialog();
        }
    }
}
