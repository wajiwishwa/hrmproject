namespace HRM_PROJECT_PIBT
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTravelling = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOK.Location = new System.Drawing.Point(333, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 33);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(31, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 33);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            this.btnCalculate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnCalculate_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gross Salary";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotal.Location = new System.Drawing.Point(240, 238);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 26);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTotal_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Other";
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOther.Location = new System.Drawing.Point(240, 166);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(178, 26);
            this.txtOther.TabIndex = 3;
            this.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOther.TextChanged += new System.EventHandler(this.TxtOther_TextChanged);
            this.txtOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOther_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trvalling Allowance";
            // 
            // txtTravelling
            // 
            this.txtTravelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTravelling.Location = new System.Drawing.Point(240, 122);
            this.txtTravelling.Name = "txtTravelling";
            this.txtTravelling.Size = new System.Drawing.Size(178, 26);
            this.txtTravelling.TabIndex = 2;
            this.txtTravelling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTravelling.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTravelling_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basic Allowance";
            // 
            // txtAllowance
            // 
            this.txtAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAllowance.Location = new System.Drawing.Point(240, 79);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(178, 26);
            this.txtAllowance.TabIndex = 1;
            this.txtAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAllowance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAllowance_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Salary";
            // 
            // txtBasic
            // 
            this.txtBasic.AcceptsTab = true;
            this.txtBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBasic.Location = new System.Drawing.Point(240, 39);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(178, 26);
            this.txtBasic.TabIndex = 0;
            this.txtBasic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBasic.TextChanged += new System.EventHandler(this.TxtBasic_TextChanged);
            this.txtBasic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBasic_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(406, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 25);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.Panel2_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTravelling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBasic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTravelling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBasic;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel2;
    }
}