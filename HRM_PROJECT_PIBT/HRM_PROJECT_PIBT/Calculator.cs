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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public string subtotal
        {
            get { return txtTotal.Text; }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f ;

            a = 0;
            b = 0;
            c = 0;
            d = 0;
            f = 0;

            a = Convert.ToInt32(txtBasic.Text);
            b = Convert.ToInt32(txtAllowance.Text);
            c = Convert.ToInt32(txtTravelling.Text);
            d = Convert.ToInt32(txtOther.Text);

            f = a + b + c + d;
            txtTotal.Text = f.ToString();
        }

        private void TxtBasic_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtBasic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtAllowance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtTravelling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtOther_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtOther_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtTotal_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            txtBasic.Text = "0";
            txtAllowance.Text = "0";
            txtTravelling.Text = "0";
            txtOther.Text = "0";
            txtTotal.Text = "0";
        }

        private void BtnCalculate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
