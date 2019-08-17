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
        ApartmentDB tblContract = new ApartmentDB();
        #endregion Member

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
            }
            else
            {
                dtpContractDate.Focus();
            }

        }

        protected override void DoReset()
        {
            Utilities.ResetAllControls(this);
            Contract_ID = string.Empty;
        }

        protected override void DoSave()
        {
            Success = true;
            CheckData();

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            if (FormState == "new")
            {
                #region Save
               
                #endregion
            }
            else if (FormState == "edit")
            {
                #region Edit
                
                #endregion
            }
        }

        private void ShowData(string Contract_ID)
        {
            if (!string.IsNullOrEmpty(Contract_ID))
            {
                #region Get data contract
                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblContract WHERE Contract_ID = '" + Contract_ID + "'";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    dbConString.Com.Parameters.Clear();
                    dbConString.Com.Parameters.Add("@Contract_ID", SqlDbType.VarChar).Value = Contract_ID;
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
               
            }

           
        }

        private void CheckData()
        {

            if (string.IsNullOrEmpty(txtContractNo.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อสินค้า", "คำเตือน", MessageBoxButtons.OK);
                Success = false;
                txtContractNo.Focus();
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
        }
    }
}
