using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ApartmentSmart.Class;
using ApartmentSmart.Data;

namespace ApartmentSmart
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        LoginDS tblLogin = new LoginDS();

        private void CloseAllChildForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        public bool rbMenuOnEnabled
        {
            get { return rbMenu.Enabled; }
            set { rbMenu.Enabled = value; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CloseAllChildForm();

            rbMenu.Enabled = true;

            frmLogin fMenu = new frmLogin();
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show(this);
        }

        private void rbtSetup_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดหน้าจอ ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                CloseAllChildForm();

                rbMenu.Enabled = false;

                frmLogin fMenu = new frmLogin();
                fMenu.StartPosition = FormStartPosition.CenterScreen;
                fMenu.Show(this);
                //this.Close();
            }
        }

        private void rbtOrg_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmOrg fMenu = new frmOrg();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void rbtUser_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmUser fMenu = new frmUser();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void rbtProduct_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmRoomList fMenu = new frmRoomList();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void rbtTenant_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmRenterList fMenu = new frmRenterList();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmContractList fMenu = new frmContractList();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void rbtReceiver_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmRecordList fMenu = new frmRecordList();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmPaymentList fMenu = new frmPaymentList();
            fMenu.MdiParent = this;
            fMenu.Type_Form = "ALL";
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmContractList fMenu = new frmContractList();
            fMenu.ContractStatus = "PLEDGE";
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmContractList fMenu = new frmContractList();
            fMenu.ContractStatus = "STAY";
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void btnRptRoomList_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmrptRoomList fMenu = new frmrptRoomList();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void btnRptRenterLists_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmrptRenterList fMenu = new frmrptRenterList();
            fMenu.MdiParent = this;
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }

        private void btnPaymentAccrued_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();
            frmPaymentList fMenu = new frmPaymentList();
            fMenu.MdiParent = this;
            fMenu.Type_Form = "Accrued";
            fMenu.StartPosition = FormStartPosition.CenterScreen;
            fMenu.Show();
        }
    }
}
