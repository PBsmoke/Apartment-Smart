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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool IsLogin = false;

        LoginDS tblLogin = new LoginDS();
        ApartmentDB tblUser = new ApartmentDB();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            bool IsCheckLogin = false;

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("กรุณากรอกรหัสผู้ใช้", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("กรุณากรอกรหัสผ่าน", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtUsername.Focus();
                return;
            }



            if (!IsCheckLogin)
            {
                tblLogin = ProfileConfig.Load();
                if (tblLogin.DBProfile.Count > 0)
                {
                    dbConString.ServerName = tblLogin.DBProfile[0].ServerName;
                    dbConString.DBName = tblLogin.DBProfile[0].DataBase;
                    dbConString.Sa = tblLogin.DBProfile[0].DBLogin;
                    dbConString.SaPassword = tblLogin.DBProfile[0].DBPassword;

                    IsCheckLogin = dbConString.CheckOpenConn();
                    if (!IsCheckLogin)
                    {
                        DBConfig fConfig = new DBConfig();
                        fConfig.ShowDialog();
                        IsCheckLogin = dbConString.CheckOpenConn();
                    }
                }
                else
                {
                    DBConfig fConfig = new DBConfig();
                    fConfig.ShowDialog();
                    IsCheckLogin = dbConString.CheckOpenConn();
                }
            }

            if (IsCheckLogin)
            {
                try
                {
                    string sqlTmp = "";
                    sqlTmp = "SELECT * FROM tblUser WHERE Username = '" + txtUsername.Text.Trim() + "' AND User_Password = '" + txtPassword.Text.Trim() + "' ";
                    DataSet Ds = new DataSet();
                    dbConString.Com = new SqlCommand();
                    dbConString.Com.CommandType = CommandType.Text;
                    dbConString.Com.CommandText = sqlTmp;
                    dbConString.Com.Connection = dbConString.mySQLConn;

                    SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                    //dr = dbConString.Com.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tblUser.Clear();
                    da.Fill(tblUser, "tblUser");
                    da.Dispose();
                    if (tblUser.tblUser.Rows.Count > 0)
                    {
                        //    if (tblUser.tblOrg.Rows.Count > 0)
                        //    {
                        //        dbConString.OrgName = tblUser.tblOrg[0].OrgName;
                        //        dbConString.TraderName = tblUser.tblOrg[0].TraderName;
                        //        dbConString.Address = tblUser.tblOrg[0].Address;
                        //        dbConString.TaxID = tblUser.tblOrg[0].TaxID;
                        //        dbConString.TaxRate = tblUser.tblOrg[0].TaxRate;
                        //        dbConString.Tel = tblUser.tblOrg[0].Tel;
                        //        dbConString.Fax = tblUser.tblOrg[0].Fax;

                        //        dbConString.EmpId = tblUser.uv_User[0].EmpID;
                        //        dbConString.EmpCode = tblUser.uv_User[0].EmpCode;
                        //        dbConString.EmpName = tblUser.uv_User[0].FullName;

                        //        dbConString.SerialPorts = tblUser.tblDrawerSetting[0].SerialPorts;
                        //        dbConString.Baudrates = Convert.ToInt32(tblUser.tblDrawerSetting[0].Baudrates);
                        //        dbConString.IsUsing = tblUser.tblDrawerSetting[0].IsUsing;

                        //        ((frmMain)this.Owner).rbMenuOnEnabled = true;
                        //        
                        //    }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("รหัสผ่านไม่ถูกต้อง !!", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }   
        }

        private void tsReset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool IsCheckLogin = false;

                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("กรุณากรอกรหัสผู้ใช้", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("กรุณากรอกรหัสผ่าน", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtUsername.Focus();
                    return;
                }

                if (!IsCheckLogin)
                {
                    tblLogin = ProfileConfig.Load();
                    if (tblLogin.DBProfile.Count > 0)
                    {
                        dbConString.ServerName = tblLogin.DBProfile[0].ServerName;
                        dbConString.DBName = tblLogin.DBProfile[0].DataBase;
                        dbConString.Sa = tblLogin.DBProfile[0].DBLogin;
                        dbConString.SaPassword = tblLogin.DBProfile[0].DBPassword;

                        IsCheckLogin = dbConString.CheckOpenConn();
                        if (!IsCheckLogin)
                        {
                            DBConfig fConfig = new DBConfig();
                            fConfig.ShowDialog();
                            IsCheckLogin = dbConString.CheckOpenConn();
                        }
                    }
                    else
                    {
                        DBConfig fConfig = new DBConfig();
                        fConfig.ShowDialog();
                        IsCheckLogin = dbConString.CheckOpenConn();
                    }
                }

                if (IsCheckLogin)
                {
                    try
                    {
                        string sqlTmp = "";
                        sqlTmp = "SELECT * FROM tblUser WHERE Username = '" + txtUsername.Text.Trim() + "' AND User_Password = '" + txtPassword.Text.Trim() + "' ";
                        DataSet Ds = new DataSet();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.Connection = dbConString.mySQLConn;

                        SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                        //dr = dbConString.Com.ExecuteReader();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        tblUser.Clear();
                        da.Fill(tblUser, "tblUser");
                        da.Dispose();
                        if (tblUser.tblUser.Rows.Count > 0)
                        {
                            //    if (tblUser.tblOrg.Rows.Count > 0)
                            //    {
                            //        dbConString.OrgName = tblUser.tblOrg[0].OrgName;
                            //        dbConString.TraderName = tblUser.tblOrg[0].TraderName;
                            //        dbConString.Address = tblUser.tblOrg[0].Address;
                            //        dbConString.TaxID = tblUser.tblOrg[0].TaxID;
                            //        dbConString.TaxRate = tblUser.tblOrg[0].TaxRate;
                            //        dbConString.Tel = tblUser.tblOrg[0].Tel;
                            //        dbConString.Fax = tblUser.tblOrg[0].Fax;

                            //        dbConString.EmpId = tblUser.uv_User[0].EmpID;
                            //        dbConString.EmpCode = tblUser.uv_User[0].EmpCode;
                            //        dbConString.EmpName = tblUser.uv_User[0].FullName;

                            //        dbConString.SerialPorts = tblUser.tblDrawerSetting[0].SerialPorts;
                            //        dbConString.Baudrates = Convert.ToInt32(tblUser.tblDrawerSetting[0].Baudrates);
                            //        dbConString.IsUsing = tblUser.tblDrawerSetting[0].IsUsing;

                            //        ((frmMain)this.Owner).rbMenuOnEnabled = true;
                            //    }

                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("รหัสผ่านไม่ถูกต้อง !!", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
