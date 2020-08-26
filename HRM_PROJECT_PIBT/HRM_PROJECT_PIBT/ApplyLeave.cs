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
    public partial class ApplyLeave : Form
    {
        public ApplyLeave()
        {
            InitializeComponent();
        }
        SqlConnection pibtconnect = new SqlConnection("Data Source=WIN-39J4B3ES75O;Initial Catalog=HRM_PROJECT_PIBT;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void BtnSearchEmp_Click(object sender, EventArgs e)
        {
            pibtconnect.Open();
            SqlCommand cmd = new SqlCommand("select emp_name from empz_table where emp_id='" + txtEmpID.Text+ "'", pibtconnect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr.GetValue(0).ToString();

            }
            pibtconnect.Close();

            displaydata();
        }

        private void BtnApplyLeave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && comboLeave.Text != "" && txtLeaveDays.Text != "")
            {
                pibtconnect.Open();
                cmd = new SqlCommand("update empz_table set emp_name=@emp_name,leave_type=@leave_type,leaves=@leaves where emp_id=@emp_id", pibtconnect);

                cmd.Parameters.AddWithValue("@emp_id", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@emp_name", txtName.Text);
                cmd.Parameters.AddWithValue("@leave_type", comboLeave.Text);
                cmd.Parameters.AddWithValue("@leaves", txtLeaveDays.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Leave Applied Successfully");
                pibtconnect.Close();
                displaydata();
                clearform();
                
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }
        public void clearform()
        {
            txtEmpID.Text = "";
            txtName.Text = "";
            comboLeave.Text = "";
            txtLeaveDays.Text = "";
        }
       
        public void displaydata()
        {
            pibtconnect.Open();

            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT emp_id, emp_name, leave_type, leaves FROM empz_table where emp_id = '" + txtEmpID.Text + "'", pibtconnect);
            adapt.Fill(dt);
            dataGridView.DataSource = dt;

            pibtconnect.Close();
        }

        private void DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void TxtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnSearchEmp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ComboLeave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtLeaveDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnApplyLeave_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            UsersMainPage umpage = new UsersMainPage();
            umpage.ShowDialog();
        }
    }
}
