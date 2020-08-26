using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRM_PROJECT_PIBT
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRegistration empregform = new EmployeeRegistration();
            empregform.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search srch = new Search();
            srch.ShowDialog();
        }
    }
}
