namespace financial_freedom_c
{
    partial class InvestmentGrowthForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonthlyInvLabel = new System.Windows.Forms.Label();
            this.lblYearsLabel = new System.Windows.Forms.Label();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.TxtMIValue = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInterestRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Investment Growth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(941, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "This goal focuses on growing your savings over time by investing a fixed amount e" +
    "very month.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMonthlyInvLabel
            // 
            this.lblMonthlyInvLabel.AutoSize = true;
            this.lblMonthlyInvLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyInvLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMonthlyInvLabel.Location = new System.Drawing.Point(35, 118);
            this.lblMonthlyInvLabel.Name = "lblMonthlyInvLabel";
            this.lblMonthlyInvLabel.Size = new System.Drawing.Size(186, 23);
            this.lblMonthlyInvLabel.TabIndex = 2;
            this.lblMonthlyInvLabel.Text = "Monthly Investment:";
            // 
            // lblYearsLabel
            // 
            this.lblYearsLabel.AutoSize = true;
            this.lblYearsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYearsLabel.Location = new System.Drawing.Point(35, 161);
            this.lblYearsLabel.Name = "lblYearsLabel";
            this.lblYearsLabel.Size = new System.Drawing.Size(156, 23);
            this.lblYearsLabel.TabIndex = 3;
            this.lblYearsLabel.Text = "Duration (years):";
            // 
            // cmbYears
            // 
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "20",
            "25",
            "30"});
            this.cmbYears.Location = new System.Drawing.Point(197, 161);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(121, 31);
            this.cmbYears.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(444, 415);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 60);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult.Location = new System.Drawing.Point(319, 261);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(409, 135);
            this.txtResult.TabIndex = 8;
            // 
            // TxtMIValue
            // 
            this.TxtMIValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TxtMIValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMIValue.Location = new System.Drawing.Point(227, 118);
            this.TxtMIValue.Multiline = true;
            this.TxtMIValue.Name = "TxtMIValue";
            this.TxtMIValue.ReadOnly = true;
            this.TxtMIValue.Size = new System.Drawing.Size(194, 36);
            this.TxtMIValue.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 53);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(856, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 53);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exist";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Interest Rate (annual)";
            // 
            // cmbInterestRate
            // 
            this.cmbInterestRate.FormattingEnabled = true;
            this.cmbInterestRate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbInterestRate.Location = new System.Drawing.Point(227, 204);
            this.cmbInterestRate.Name = "cmbInterestRate";
            this.cmbInterestRate.Size = new System.Drawing.Size(121, 24);
            this.cmbInterestRate.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(439, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Result summary ";
            // 
            // InvestmentGrowthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1029, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbInterestRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.TxtMIValue);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbYears);
            this.Controls.Add(this.lblYearsLabel);
            this.Controls.Add(this.lblMonthlyInvLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvestmentGrowthForm";
            this.Text = "InvestmentGrowthForm";
            this.Load += new System.EventHandler(this.InvestmentGrowthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonthlyInvLabel;
        private System.Windows.Forms.Label lblYearsLabel;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox TxtMIValue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbInterestRate;
        private System.Windows.Forms.Label label5;
    }
}