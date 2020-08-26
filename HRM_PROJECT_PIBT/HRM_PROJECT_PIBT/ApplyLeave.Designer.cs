namespace HRM_PROJECT_PIBT
{
    partial class ApplyLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLeave));
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.btnApplyLeave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLeave = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.Label();
            this.txtLeaveDays = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLogout.Location = new System.Drawing.Point(795, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(77, 24);
            this.lblLogout.TabIndex = 6;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "&Log Out";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLogout_LinkClicked);
            // 
            // btnApplyLeave
            // 
            this.btnApplyLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnApplyLeave.Location = new System.Drawing.Point(246, 377);
            this.btnApplyLeave.Name = "btnApplyLeave";
            this.btnApplyLeave.Size = new System.Drawing.Size(129, 34);
            this.btnApplyLeave.TabIndex = 4;
            this.btnApplyLeave.Text = "&Apply Leave";
            this.btnApplyLeave.UseVisualStyleBackColor = true;
            this.btnApplyLeave.Click += new System.EventHandler(this.BtnApplyLeave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(395, 168);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(477, 243);
            this.dataGridView.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Leave Type";
            // 
            // comboLeave
            // 
            this.comboLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboLeave.FormattingEnabled = true;
            this.comboLeave.Items.AddRange(new object[] {
            "Sick Leave",
            "Casual Leave",
            "Maternity Leave",
            "Transfer Leave"});
            this.comboLeave.Location = new System.Drawing.Point(155, 255);
            this.comboLeave.Name = "comboLeave";
            this.comboLeave.Size = new System.Drawing.Size(220, 28);
            this.comboLeave.TabIndex = 2;
            this.comboLeave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboLeave_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. of Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // txtEmployee
            // 
            this.txtEmployee.AutoSize = true;
            this.txtEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(4, 171);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(111, 20);
            this.txtEmployee.TabIndex = 0;
            this.txtEmployee.Text = "Employee ID";
            // 
            // txtLeaveDays
            // 
            this.txtLeaveDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLeaveDays.Location = new System.Drawing.Point(155, 302);
            this.txtLeaveDays.Name = "txtLeaveDays";
            this.txtLeaveDays.Size = new System.Drawing.Size(220, 26);
            this.txtLeaveDays.TabIndex = 3;
            this.txtLeaveDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLeaveDays_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(155, 214);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(220, 26);
            this.txtName.TabIndex = 20;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpID.Location = new System.Drawing.Point(155, 168);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(119, 26);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmpID_KeyDown);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchEmp.Location = new System.Drawing.Point(280, 165);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(95, 33);
            this.btnSearchEmp.TabIndex = 1;
            this.btnSearchEmp.Text = "&Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            this.btnSearchEmp.Click += new System.EventHandler(this.BtnSearchEmp_Click);
            this.btnSearchEmp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.BtnSearchEmp_PreviewKeyDown);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(8, 378);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<- &Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 100);
            this.panel1.TabIndex = 28;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(145, 44);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(284, 55);
            this.lbl_Account.TabIndex = 56;
            this.lbl_Account.Text = "Apply Leave";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(672, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 57;
            // 
            // ApplyLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnApplyLeave);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboLeave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtLeaveDays);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplyLeave";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Button btnApplyLeave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboLeave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtEmployee;
        private System.Windows.Forms.TextBox txtLeaveDays;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Panel panel2;
    }
}