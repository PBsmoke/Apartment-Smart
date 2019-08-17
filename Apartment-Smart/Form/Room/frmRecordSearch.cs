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
    public partial class frmRecordSearch : Form
    {
        public frmRecordSearch()
        {
            InitializeComponent();
        }

        public bool ProductStatus = false;
        public bool DealerStatus = false;
        public bool ProductStatusTemp = false;

        public string   ProductID,
                        ProductCode,
                        ProductName,
                        ProductNameEng,
                        ProductTypeID,
                        ProductTypeCode,
                        ProductTypeName,
                        ProductTypeNameEng,
                        UnitID,
                        UnitCode,
                        UnitName;
        public decimal  ProductCost,
                        ProductPrice;
        public int      ProductTotal;



        private void frmProductSearch_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            ShowData();
        }

        #region Member
        #endregion

        private void ShowData()
        {
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tblProduct Order BY ProductCode";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //tblProduct.Clear();
                //da.Fill(tblProduct, "tblProduct");
                //da.Dispose();
                //dgvProductSearch.DataSource = tblProduct.tblProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Whereclause = string.Empty;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Whereclause = txtSearch.Text;
            }
            else
            {
                Whereclause = string.Empty;
            }

            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tblProduct ";
                if (!string.IsNullOrEmpty(Whereclause))
                {
                    sqlTmp += " WHERE ProductCode LIKE '%" + Whereclause + "%' OR ProductName LIKE '%" + Whereclause + "%' ";
                }
                sqlTmp += " ORDER BY ProductCode";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //tblProduct.Clear();
                //da.Fill(tblProduct, "tblProduct");
                da.Dispose();
                //dgvProductSearch.DataSource = tblProduct.tblProduct;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvProductSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ProductID = dgvProductSearch.Rows[e.RowIndex].Cells[colProductID.Name].Value.ToString();
            //ProductCode = dgvProductSearch.Rows[e.RowIndex].Cells[colProductCode.Name].Value.ToString();
            //ProductName = dgvProductSearch.Rows[e.RowIndex].Cells[colProductName.Name].Value.ToString();
            //ProductNameEng = dgvProductSearch.Rows[e.RowIndex].Cells[colProductNameEng.Name].Value.ToString();
            //ProductTypeID = dgvProductSearch.Rows[e.RowIndex].Cells[colProductTypeID.Name].Value.ToString();
            //ProductCost = Convert.ToDecimal(dgvProductSearch.Rows[e.RowIndex].Cells[colProductCost.Name].Value.ToString());
            //ProductPrice = Convert.ToDecimal(dgvProductSearch.Rows[e.RowIndex].Cells[colProductPrice.Name].Value.ToString());
            //ProductTotal = Convert.ToInt32(dgvProductSearch.Rows[e.RowIndex].Cells[colProductTotal.Name].Value.ToString());
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Whereclause = string.Empty;
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    Whereclause = txtSearch.Text;
                }
                else
                {
                    Whereclause = string.Empty;
                }

                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblProduct ";
                    if (!string.IsNullOrEmpty(Whereclause))
                    {
                        sqlTmp += " WHERE ProductCode LIKE '%" + Whereclause + "%' OR ProductName LIKE '%" + Whereclause + "%' ";
                    }
                    sqlTmp += " ORDER BY ProductCode";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;
                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //tblProduct.Clear();
                    //da.Fill(tblProduct, "tblProduct");
                    //da.Dispose();
                    //dgvProductSearch.DataSource = tblProduct.tblProduct;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
