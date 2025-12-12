namespace financial_freedom_c
{
    partial class RetirementPlanForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbGrowth = new System.Windows.Forms.ComboBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthlySavingValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(869, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(420, 382);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 36);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(39, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 36);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbGrowth
            // 
            this.cmbGrowth.FormattingEnabled = true;
            this.cmbGrowth.Items.AddRange(new object[] {
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
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.cmbGrowth.Location = new System.Drawing.Point(299, 269);
            this.cmbGrowth.Name = "cmbGrowth";
            this.cmbGrowth.Size = new System.Drawing.Size(121, 24);
            this.cmbGrowth.TabIndex = 3;
            // 
            // cmbYears
            // 
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
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbYears.Location = new System.Drawing.Point(256, 196);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(121, 24);
            this.cmbYears.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Yellow;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(16, 13);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(370, 181);
            this.txtResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Years Until Retirement";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(259, 133);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(207, 22);
            this.label.TabIndex = 7;
            this.label.Text = "Monthly Saving Capacity";
            this.label.Click += new System.EventHandler(this.lblMonthlySavingValue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Expected Annual Growth Rate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Location = new System.Drawing.Point(485, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 214);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Results";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMonthlySavingValue
            // 
            this.lblMonthlySavingValue.AutoSize = true;
            this.lblMonthlySavingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySavingValue.Location = new System.Drawing.Point(18, 130);
            this.lblMonthlySavingValue.Name = "lblMonthlySavingValue";
            this.lblMonthlySavingValue.Size = new System.Drawing.Size(235, 25);
            this.lblMonthlySavingValue.TabIndex = 10;
            this.lblMonthlySavingValue.Text = "Monthly Saving Capacity:";
            this.lblMonthlySavingValue.Click += new System.EventHandler(this.lblMonthlySavingValue_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Retirement Plan ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(888, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Plan your expected retirement savings based on your monthly saving capacity and i" +
    "nvestment growth.";
            // 
            // RetirementPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMonthlySavingValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYears);
            this.Controls.Add(this.cmbGrowth);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Name = "RetirementPlanForm";
            this.Text = "RetirementPlanForm";
            this.Load += new System.EventHandler(this.RetirementPlanForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbGrowth;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonthlySavingValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}