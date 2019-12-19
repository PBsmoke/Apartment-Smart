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
    public partial class frmRoomSearch : Form
    {
        public frmRoomSearch()
        {
            InitializeComponent();
        }

        public string Room_ID, Room_Number, Room_Type;
        public decimal Price_daily,
                        Price_monthly;
        private void frmProductSearch_Load(object sender, EventArgs e)
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
            Room_ID = dgvProductSearch.Rows[e.RowIndex].Cells[colRoom_ID.Name].Value.ToString();
            Room_Number = dgvProductSearch.Rows[e.RowIndex].Cells[colRoom_number.Name].Value.ToString();
            Room_Type = dgvProductSearch.Rows[e.RowIndex].Cells[colRoomType.Name].Value.ToString();
            Price_daily = Convert.ToDecimal(dgvProductSearch.Rows[e.RowIndex].Cells[colRoom_Price_daily.Name].Value.ToString());
            Price_monthly = Convert.ToDecimal(dgvProductSearch.Rows[e.RowIndex].Cells[colRoom_Price_monthly.Name].Value.ToString());
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
            sqlTmp = "select * from uv_room r WHERE Room_status = 'A6DEF890-61C9-44A3-91DD-DBA3BBE98327' ";

            if (!string.IsNullOrEmpty(Whereclause))
            {
                sqlTmp += " and ( r.Room_number LIKE '%" + Whereclause + "%' OR s.Name LIKE '%" + Whereclause + "%' )";
            }

            sqlTmp += " ORDER BY Room_floor , Room_number ";

            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblRoom.Clear();
            da.Fill(tblRoom, "uv_room");
            da.Dispose();
            dgvProductSearch.DataSource = tblRoom.uv_room;
        }
    }
}
