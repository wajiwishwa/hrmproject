using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRM_PROJECT_PIBT
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        string pibtconnect = @"Data Source=WIN-39J4B3ES75O;Initial Catalog=HRM_PROJECT_PIBT;Integrated Security=True;";

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                label_info.Text ="Please provide\nUserName and Password";
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(pibtconnect);
                SqlCommand cmd = new SqlCommand("Select * from login_table where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    //MessageBox.Show("Login Successful!");
                    this.Hide();
                    MainPage mpage = new MainPage();
                    mpage.Show();
                }
                else
                {
                    label_info.Text="Login Failed!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            label_info.Text = "";
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();
        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnOtherUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersMainPage umpage = new UsersMainPage();
            umpage.ShowDialog();
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}