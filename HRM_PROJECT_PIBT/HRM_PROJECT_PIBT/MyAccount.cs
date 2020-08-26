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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }
        SqlConnection pibtconnect = new SqlConnection("Data Source=WIN-39J4B3ES75O;Initial Catalog=HRM_PROJECT_PIBT;Integrated Security=True;");
        SqlCommand cmd;
        private void BtnEnable_Click(object sender, EventArgs e)
        {
            enabletxt();
        }

        private void enabletxt()
        {
            txtName.ReadOnly = false;
            txtAge.ReadOnly = false;
            txtMobile.ReadOnly = false;
        }

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UsersMainPage umpage = new UsersMainPage();
            umpage.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            pibtconnect.Open();
            SqlCommand cmd = new SqlCommand("select emp_name,age,mobile,gender,department,salary from empz_table where emp_id='" + txtEmpID.Text + "'", pibtconnect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr.GetValue(0).ToString();
                txtAge.Text = dr.GetValue(1).ToString();
                txtMobile.Text = dr.GetValue(2).ToString();
                txtGender.Text = dr.GetValue(3).ToString();
                txtDepartment.Text = dr.GetValue(4).ToString();
                txtSalary.Text = dr.GetValue(5).ToString();

            }
            pibtconnect.Close();
        }
        public void cleartext()
        {
            txtEmpID.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtMobile.Text = "";
            txtGender.Text = "";
            txtDepartment.Text = "";
            txtSalary.Text = "";

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAge.Text != "" && txtMobile.Text != "")
            {
                pibtconnect.Open();
                cmd = new SqlCommand("update empz_table set emp_name=@emp_name,age=@age,mobile=@mobile where emp_id=@emp_id", pibtconnect);

                cmd.Parameters.AddWithValue("@emp_id", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@emp_name", txtName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
                pibtconnect.Close();

                
                cleartext();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void TxtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnEnable_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnUpdate_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
