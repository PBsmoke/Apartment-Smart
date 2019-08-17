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
    public partial class frmRecord : BaseInfo
    {
        public frmRecord()
        {
            InitializeComponent();
        }

        #region Member
        #endregion Member

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void DoLoadForm()
        {

        }

        protected override void DoReset()
        {
            
        }

        protected override void DoSave()
        {
           
        }
    }
}
