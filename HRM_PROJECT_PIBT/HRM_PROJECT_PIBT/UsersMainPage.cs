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
    public partial class UsersMainPage : Form
    {
        public UsersMainPage()
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
            MyAccount myacc = new MyAccount();
            myacc.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplyLeave leaveform = new ApplyLeave();
            leaveform.ShowDialog();
        }
    }
}
