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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection pibtconnect = new SqlConnection("Data Source=WIN-39J4B3ES75O;Initial Catalog=HRM_PROJECT_PIBT;Integrated Security=True;");
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            pibtconnect.Open();
            SqlCommand cmd = new SqlCommand("SELECT emp_id,emp_name,age,mobile,department,salary FROM empz_table", pibtconnect);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            pibtconnect.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            pibtconnect.Open();
            SqlCommand cmd = new SqlCommand("SELECT emp_id,emp_name,age,mobile,department,salary FROM empz_table WHERE Department='" + comboDepartment.Text + "'", pibtconnect);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView.DataSource = dt;
            pibtconnect.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mpage = new MainPage();
            mpage.ShowDialog();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
