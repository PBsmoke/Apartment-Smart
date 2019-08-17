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
    }
}
