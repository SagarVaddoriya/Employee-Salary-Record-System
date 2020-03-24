namespace A2SagarVaddoriya
{
    partial class Form1
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
            this.rdoHourly = new System.Windows.Forms.RadioButton();
            this.rdoCommission = new System.Windows.Forms.RadioButton();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHourWage = new System.Windows.Forms.TextBox();
            this.txtHourWork = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHourWage = new System.Windows.Forms.Label();
            this.lblHourWork = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNetEarning = new System.Windows.Forms.TextBox();
            this.txtLessTax = new System.Windows.Forms.TextBox();
            this.txtGrossEarning = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoHourly
            // 
            this.rdoHourly.AutoSize = true;
            this.rdoHourly.Location = new System.Drawing.Point(29, 45);
            this.rdoHourly.Name = "rdoHourly";
            this.rdoHourly.Size = new System.Drawing.Size(114, 24);
            this.rdoHourly.TabIndex = 0;
            this.rdoHourly.TabStop = true;
            this.rdoHourly.Text = "Hourly Paid";
            this.rdoHourly.UseVisualStyleBackColor = true;
            // 
            // rdoCommission
            // 
            this.rdoCommission.AutoSize = true;
            this.rdoCommission.Location = new System.Drawing.Point(306, 45);
            this.rdoCommission.Name = "rdoCommission";
            this.rdoCommission.Size = new System.Drawing.Size(153, 24);
            this.rdoCommission.TabIndex = 1;
            this.rdoCommission.TabStop = true;
            this.rdoCommission.Text = "Commision Base";
            this.rdoCommission.UseVisualStyleBackColor = true;
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Location = new System.Drawing.Point(567, 45);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(133, 24);
            this.rdoWeekly.TabIndex = 2;
            this.rdoWeekly.TabStop = true;
            this.rdoWeekly.Text = "Weekly Salary";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHourly);
            this.groupBox1.Controls.Add(this.rdoWeekly);
            this.groupBox1.Controls.Add(this.rdoCommission);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Type Of Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHourWage);
            this.groupBox2.Controls.Add(this.txtHourWork);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblHourWage);
            this.groupBox2.Controls.Add(this.lblHourWork);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(27, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 207);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input The Employee\'s Imformation";
            // 
            // txtHourWage
            // 
            this.txtHourWage.Location = new System.Drawing.Point(244, 169);
            this.txtHourWage.Name = "txtHourWage";
            this.txtHourWage.Size = new System.Drawing.Size(258, 26);
            this.txtHourWage.TabIndex = 5;
            // 
            // txtHourWork
            // 
            this.txtHourWork.Location = new System.Drawing.Point(244, 117);
            this.txtHourWork.Name = "txtHourWork";
            this.txtHourWork.Size = new System.Drawing.Size(258, 26);
            this.txtHourWork.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblHourWage
            // 
            this.lblHourWage.AutoSize = true;
            this.lblHourWage.Location = new System.Drawing.Point(29, 169);
            this.lblHourWage.Name = "lblHourWage";
            this.lblHourWage.Size = new System.Drawing.Size(108, 20);
            this.lblHourWage.TabIndex = 2;
            this.lblHourWage.Text = "Hourly Wage :";
            // 
            // lblHourWork
            // 
            this.lblHourWork.AutoSize = true;
            this.lblHourWork.Location = new System.Drawing.Point(29, 117);
            this.lblHourWork.Name = "lblHourWork";
            this.lblHourWork.Size = new System.Drawing.Size(119, 20);
            this.lblHourWork.TabIndex = 1;
            this.lblHourWork.Text = "Hours Worked :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(645, 188);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 34);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(645, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 31);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(645, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNetEarning);
            this.groupBox3.Controls.Add(this.txtLessTax);
            this.groupBox3.Controls.Add(this.txtGrossEarning);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(27, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 163);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculated Wage";
            // 
            // txtNetEarning
            // 
            this.txtNetEarning.Location = new System.Drawing.Point(244, 120);
            this.txtNetEarning.Name = "txtNetEarning";
            this.txtNetEarning.ReadOnly = true;
            this.txtNetEarning.Size = new System.Drawing.Size(258, 26);
            this.txtNetEarning.TabIndex = 5;
            // 
            // txtLessTax
            // 
            this.txtLessTax.Location = new System.Drawing.Point(244, 82);
            this.txtLessTax.Name = "txtLessTax";
            this.txtLessTax.ReadOnly = true;
            this.txtLessTax.Size = new System.Drawing.Size(258, 26);
            this.txtLessTax.TabIndex = 4;
            // 
            // txtGrossEarning
            // 
            this.txtGrossEarning.Location = new System.Drawing.Point(244, 39);
            this.txtGrossEarning.Name = "txtGrossEarning";
            this.txtGrossEarning.ReadOnly = true;
            this.txtGrossEarning.Size = new System.Drawing.Size(258, 26);
            this.txtGrossEarning.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Net Earnings :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Less Tax :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gross Earning :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Employees :";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(271, 581);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(258, 28);
            this.cmbEmployee.TabIndex = 10;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoHourly;
        private System.Windows.Forms.RadioButton rdoCommission;
        private System.Windows.Forms.RadioButton rdoWeekly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHourWage;
        private System.Windows.Forms.TextBox txtHourWork;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHourWage;
        private System.Windows.Forms.Label lblHourWork;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.TextBox txtNetEarning;
        private System.Windows.Forms.TextBox txtLessTax;
        private System.Windows.Forms.TextBox txtGrossEarning;
    }
}

