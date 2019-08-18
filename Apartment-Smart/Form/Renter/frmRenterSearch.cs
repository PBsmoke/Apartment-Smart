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
    public partial class frmRenterSearch : Form
    {
        public frmRenterSearch()
        {
            InitializeComponent();
        }

        public string Renter_ID, Renter_Fullname;
        private void frmRenterSearch_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            ShowData();
        }

        #region Member
        ApartmentDB tblRoom = new ApartmentDB();
        #endregion

        private void ShowData()
        {
            searchRoom();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchRoom();
        }

        private void dgvProductSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Renter_ID = dgvProductSearch.Rows[e.RowIndex].Cells[colRenter_ID.Name].Value.ToString();
            string Renter_TitleName = dgvProductSearch.Rows[e.RowIndex].Cells[colRenter_TitleName.Name].Value.ToString();
            string Renter_Name = dgvProductSearch.Rows[e.RowIndex].Cells[colRenter_Name.Name].Value.ToString();
            string Renter_LastName = dgvProductSearch.Rows[e.RowIndex].Cells[colRenter_Lastname.Name].Value.ToString();
            Renter_Fullname = Renter_TitleName + " " + Renter_Name + " " + Renter_LastName;
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchRoom();
            }
        }

        private void searchRoom()
        {
            string sqlTmp = string.Empty;
            string Whereclause = string.Empty;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Whereclause = txtSearch.Text;
            }
            else
            {
                Whereclause = string.Empty;
            }
            sqlTmp = "select * from tblRenter ";
            if (!string.IsNullOrEmpty(Whereclause))
            {
                sqlTmp += " where Renter_TitleName LIKE '%" + Whereclause + "%' or Renter_Name LIKE '%" + Whereclause + "%' or Renter_Lastname LIKE '%" + Whereclause + "%' or Renter_Tel LIKE '%" + Whereclause + "%' ";
            }
            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblRoom.Clear();
            da.Fill(tblRoom, "tblRoom");
            da.Dispose();
            dgvProductSearch.DataSource = tblRoom.tblRoom;
        }
    }
}
