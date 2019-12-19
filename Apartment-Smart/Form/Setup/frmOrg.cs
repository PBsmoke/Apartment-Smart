using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ApartmentSmart.Class;
using ApartmentSmart.Data;

namespace ApartmentSmart
{
    public partial class frmOrg : BaseInfo
    {
        public frmOrg()
        {
            InitializeComponent();
        }

        //PosDS tblOrg = new PosDS();
        ApartmentDB aprtmentDB = new ApartmentDB();
        string Owner_ID = string.Empty;
        protected override void DoLoadForm()
        {
            ShowData();
        }

        protected override void DoSave()
        {
            try
            {
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;
                                StringBd.Append("UPDATE tblOwner SET Owner_Name = @Owner_Name ,Owner_Tax = @Owner_Tax ,Owner_Address = @Owner_Address ,Owner_Moo = @Owner_Moo ");
                StringBd.Append(" , Owner_Tambon = @Owner_Tambon, Owner_Amphur = @Owner_Amphur, Owner_Province = @Owner_Province, Owner_Zip = @Owner_Zip ");
                StringBd.Append(" , Owner_Tel = @Owner_Tel, Record_power = @Record_power, Record_water = @Record_water WHERE Owner_ID = @Owner_ID ");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@Owner_ID", SqlDbType.VarChar).Value = Owner_ID;
                dbConString.Com.Parameters.Add("@Owner_Name", SqlDbType.VarChar).Value = txtOwnerName.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Tax", SqlDbType.VarChar).Value = txtTax.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Address", SqlDbType.VarChar).Value = txtAddress.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Moo", SqlDbType.VarChar).Value = txtMoo.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Tambon", SqlDbType.VarChar).Value = txtTambon.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Amphur", SqlDbType.VarChar).Value = txtAmphur.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Province", SqlDbType.VarChar).Value = txtProvince.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Zip", SqlDbType.VarChar).Value = txtZipcode.Text.Trim();
                dbConString.Com.Parameters.Add("@Owner_Tel", SqlDbType.VarChar).Value = txtTel.Text.Trim();
                dbConString.Com.Parameters.Add("@Record_power", SqlDbType.Float).Value = Convert.ToDouble(txtPower.Text);
                dbConString.Com.Parameters.Add("@Record_water", SqlDbType.Float).Value = Convert.ToDouble(txtWater.Text);
                dbConString.Com.ExecuteNonQuery();
                dbConString.Transaction.Commit();
                MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbConString.OrgName = txtOwnerName.Text.Trim();
                dbConString.TraderName = txtTraderName.Text.Trim();
                dbConString.TaxID = txtTax.Text.Trim();
                dbConString.Tel = txtTel.Text.Trim();
                string Address = "";
                Address += txtAddress.Text.Trim() + " ";
                Address += " หมู่ " + txtMoo.Text.Trim() + " ";
                Address += " ตำบล " + txtTambon.Text.Trim() + " ";
                Address += " อำเภอ " + txtAmphur.Text.Trim() + " ";
                Address += " จังหวัด " + txtProvince.Text.Trim() + " ";
                Address += txtZipcode.Text.Trim();
                dbConString.Address = Address;
                dbConString.Power = Convert.ToDouble(txtPower.Text);
                dbConString.Water = Convert.ToDouble(txtWater.Text);
            }
            catch
            {
                dbConString.Transaction.Rollback();
            }
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tblOwner";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                //dr = dbConString.Com.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                aprtmentDB.Clear();
                da.Fill(aprtmentDB, "tblOwner");
                da.Dispose();
                if (aprtmentDB.tblOwner.Rows.Count > 0)
                {
                    Owner_ID = aprtmentDB.tblOwner[0].Owner_ID;
                    txtOwnerName.Text = aprtmentDB.tblOwner[0].Owner_Name;
                    txtTax.Text = aprtmentDB.tblOwner[0].Owner_Tax;
                    txtAddress.Text = aprtmentDB.tblOwner[0].Owner_Address;
                    txtMoo.Text = aprtmentDB.tblOwner[0].Owner_Moo;
                    txtTambon.Text = aprtmentDB.tblOwner[0].Owner_Tambon;
                    txtAmphur.Text = aprtmentDB.tblOwner[0].Owner_Amphur;
                    txtProvince.Text = aprtmentDB.tblOwner[0].Owner_Province;
                    txtZipcode.Text = aprtmentDB.tblOwner[0].Owner_Zip;
                    txtTel.Text = aprtmentDB.tblOwner[0].Owner_Tel;
                    txtPower.Text = aprtmentDB.tblOwner[0].Record_power.ToString("##0.00");
                    txtWater.Text = aprtmentDB.tblOwner[0].Record_water.ToString("##0.00");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
