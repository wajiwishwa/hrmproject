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
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
          
        }
        SqlConnection pibtconnect = new SqlConnection("Data Source=WIN-39J4B3ES75O;Initial Catalog=HRM_PROJECT_PIBT;Integrated Security=True;");
        SqlCommand cmd;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAge.Text != "" && txtMobile.Text != "" && comboGender.Text != "" && comboDepartment.Text !="" && txtSalary.Text !="")
            {
                pibtconnect.Open();
                cmd = new SqlCommand("insert into empz_table (emp_name,age,mobile,gender,department,salary) values(@emp_name,@age,@mobile,@gender,@department,@salary)",pibtconnect);
                

                cmd.Parameters.AddWithValue("@emp_name", txtName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                cmd.Parameters.AddWithValue("@department", comboDepartment.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.ExecuteNonQuery();

                pibtconnect.Close();

                MessageBox.Show("Record Inserted Successfully");
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        private void ClearData()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtMobile.Text = "";
            comboGender.Text = "";
            comboDepartment.Text = "";
            txtSalary.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mpage = new MainPage();
            mpage.ShowDialog();
        }

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void LinkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Calculator cal = new Calculator();
            cal.ShowDialog();

            txtSalary.Text = cal.subtotal;
        }

        private void TxtSalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
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

        private void ComboGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ComboDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void EmployeeRegistration_KeyDown(object sender, KeyEventArgs e)
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
    }
    
    
   
}
