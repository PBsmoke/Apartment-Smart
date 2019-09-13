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
    public partial class BaseInfo : Form
    {
        public BaseInfo()
        {
            InitializeComponent();
        }

        public string FormState;
        protected virtual void DoSave()
        { }

        protected virtual void DoReset()
        {
            Utilities.ResetAllControls(this);
        }

        protected virtual void DoLoadForm()
        { }

        private void BaseInfoForm_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            DoLoadForm();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            DoSave();
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            DoReset();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดหน้าจอ ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected virtual void DoVisibleSave(bool VisibleStatus)
        {
            tsSave.Visible = VisibleStatus;
            toolStripSeparator2.Visible = VisibleStatus;
        }

        protected virtual void DoVisibleClear(bool VisibleStatus)
        {
            tsClear.Visible = VisibleStatus;
            toolStripSeparator5.Visible = VisibleStatus;
        }
    }
}
