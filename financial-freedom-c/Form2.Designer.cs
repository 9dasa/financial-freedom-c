namespace financial_freedom_c
{
    partial class Form2
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
            this.lblFinancialDataTitle = new System.Windows.Forms.Label();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.lblExtraIncome = new System.Windows.Forms.Label();
            this.lblMonthlyExpenses = new System.Windows.Forms.Label();
            this.lblInvestmentPercentage = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtMonthlyIncome = new System.Windows.Forms.TextBox();
            this.txtExtraIncome = new System.Windows.Forms.TextBox();
            this.txtMonthlyExpenses = new System.Windows.Forms.TextBox();
            this.txtInvestmentPercentage = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGoalsTitle = new System.Windows.Forms.Label();
            this.rdoGoalFinancialStability = new System.Windows.Forms.Button();
            this.rdoGoalEmergencyFund = new System.Windows.Forms.Button();
            this.rdoGoalDebtFree = new System.Windows.Forms.Button();
            this.rdoGoalFIRE = new System.Windows.Forms.Button();
            this.rdoGoalRetirementPlan = new System.Windows.Forms.Button();
            this.rdoGoalInvestmentGrowth = new System.Windows.Forms.Button();
            this.pnlFinancialData = new System.Windows.Forms.Panel();
            this.pnlGoals = new System.Windows.Forms.Panel();
            this.pnlFinancialData.SuspendLayout();
            this.pnlGoals.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFinancialDataTitle
            // 
            this.lblFinancialDataTitle.AutoSize = true;
            this.lblFinancialDataTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialDataTitle.Location = new System.Drawing.Point(30, 25);
            this.lblFinancialDataTitle.Name = "lblFinancialDataTitle";
            this.lblFinancialDataTitle.Size = new System.Drawing.Size(220, 27);
            this.lblFinancialDataTitle.TabIndex = 0;
            this.lblFinancialDataTitle.Text = "Financial statements";
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyIncome.Location = new System.Drawing.Point(32, 91);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(114, 16);
            this.lblMonthlyIncome.TabIndex = 1;
            this.lblMonthlyIncome.Text = "Monthly Income";
            // 
            // lblExtraIncome
            // 
            this.lblExtraIncome.AutoSize = true;
            this.lblExtraIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraIncome.Location = new System.Drawing.Point(32, 149);
            this.lblExtraIncome.Name = "lblExtraIncome";
            this.lblExtraIncome.Size = new System.Drawing.Size(96, 16);
            this.lblExtraIncome.TabIndex = 2;
            this.lblExtraIncome.Text = "Extra Income";
            // 
            // lblMonthlyExpenses
            // 
            this.lblMonthlyExpenses.AutoSize = true;
            this.lblMonthlyExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyExpenses.Location = new System.Drawing.Point(32, 207);
            this.lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            this.lblMonthlyExpenses.Size = new System.Drawing.Size(132, 16);
            this.lblMonthlyExpenses.TabIndex = 3;
            this.lblMonthlyExpenses.Text = "Monthly Expenses";
            // 
            // lblInvestmentPercentage
            // 
            this.lblInvestmentPercentage.AutoSize = true;
            this.lblInvestmentPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestmentPercentage.Location = new System.Drawing.Point(32, 262);
            this.lblInvestmentPercentage.Name = "lblInvestmentPercentage";
            this.lblInvestmentPercentage.Size = new System.Drawing.Size(165, 16);
            this.lblInvestmentPercentage.TabIndex = 4;
            this.lblInvestmentPercentage.Text = "Investment Percentage";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnter.Location = new System.Drawing.Point(35, 374);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(208, 45);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // txtMonthlyIncome
            // 
            this.txtMonthlyIncome.Location = new System.Drawing.Point(35, 109);
            this.txtMonthlyIncome.Name = "txtMonthlyIncome";
            this.txtMonthlyIncome.Size = new System.Drawing.Size(173, 20);
            this.txtMonthlyIncome.TabIndex = 6;
            // 
            // txtExtraIncome
            // 
            this.txtExtraIncome.Location = new System.Drawing.Point(35, 165);
            this.txtExtraIncome.Name = "txtExtraIncome";
            this.txtExtraIncome.Size = new System.Drawing.Size(173, 20);
            this.txtExtraIncome.TabIndex = 7;
            // 
            // txtMonthlyExpenses
            // 
            this.txtMonthlyExpenses.Location = new System.Drawing.Point(35, 226);
            this.txtMonthlyExpenses.Name = "txtMonthlyExpenses";
            this.txtMonthlyExpenses.Size = new System.Drawing.Size(173, 20);
            this.txtMonthlyExpenses.TabIndex = 8;
            // 
            // txtInvestmentPercentage
            // 
            this.txtInvestmentPercentage.Location = new System.Drawing.Point(35, 281);
            this.txtInvestmentPercentage.Name = "txtInvestmentPercentage";
            this.txtInvestmentPercentage.Size = new System.Drawing.Size(173, 20);
            this.txtInvestmentPercentage.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 619);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 36);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGoalsTitle
            // 
            this.lblGoalsTitle.AutoSize = true;
            this.lblGoalsTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalsTitle.Location = new System.Drawing.Point(39, 25);
            this.lblGoalsTitle.Name = "lblGoalsTitle";
            this.lblGoalsTitle.Size = new System.Drawing.Size(187, 27);
            this.lblGoalsTitle.TabIndex = 1;
            this.lblGoalsTitle.Text = "Choose your goal";
            // 
            // rdoGoalFinancialStability
            // 
            this.rdoGoalFinancialStability.BackColor = System.Drawing.Color.Green;
            this.rdoGoalFinancialStability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGoalFinancialStability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGoalFinancialStability.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoGoalFinancialStability.Location = new System.Drawing.Point(57, 388);
            this.rdoGoalFinancialStability.Name = "rdoGoalFinancialStability";
            this.rdoGoalFinancialStability.Size = new System.Drawing.Size(169, 31);
            this.rdoGoalFinancialStability.TabIndex = 3;
            this.rdoGoalFinancialStability.Text = "Financial Stability";
            this.rdoGoalFinancialStability.UseVisualStyleBackColor = false;
            // 
            // rdoGoalEmergencyFund
            // 
            this.rdoGoalEmergencyFund.BackColor = System.Drawing.Color.Green;
            this.rdoGoalEmergencyFund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGoalEmergencyFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGoalEmergencyFund.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoGoalEmergencyFund.Location = new System.Drawing.Point(57, 335);
            this.rdoGoalEmergencyFund.Name = "rdoGoalEmergencyFund";
            this.rdoGoalEmergencyFund.Size = new System.Drawing.Size(169, 31);
            this.rdoGoalEmergencyFund.TabIndex = 4;
            this.rdoGoalEmergencyFund.Text = "Emergency Fund";
            this.rdoGoalEmergencyFund.UseVisualStyleBackColor = false;
            // 
            // rdoGoalDebtFree
            // 
            this.rdoGoalDebtFree.BackColor = System.Drawing.Color.Green;
            this.rdoGoalDebtFree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGoalDebtFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGoalDebtFree.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoGoalDebtFree.Location = new System.Drawing.Point(57, 203);
            this.rdoGoalDebtFree.Name = "rdoGoalDebtFree";
            this.rdoGoalDebtFree.Size = new System.Drawing.Size(169, 31);
            this.rdoGoalDebtFree.TabIndex = 5;
            this.rdoGoalDebtFree.Text = "Debt-Free Goal";
            this.rdoGoalDebtFree.UseVisualStyleBackColor = false;
            // 
            // rdoGoalFIRE
            // 
            this.rdoGoalFIRE.BackColor = System.Drawing.Color.Green;
            this.rdoGoalFIRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGoalFIRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGoalFIRE.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoGoalFIRE.Location = new System.Drawing.Point(57, 129);
            this.rdoGoalFIRE.Name = "rdoGoalFIRE";
            this.rdoGoalFIRE.Size = new System.Drawing.Size(169, 54);
            this.rdoGoalFIRE.TabIndex = 6;
            this.rdoGoalFIRE.Text = "Financial Independence";
            this.rdoGoalFIRE.UseVisualStyleBackColor = false;
            // 
            // rdoGoalRetirementPlan
            // 
            this.rdoGoalRetirementPlan.BackColor = System.Drawing.Color.Green;
            this.rdoGoalRetirementPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGoalRetirementPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGoalRetirementPlan.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoGoalRetirementPlan.Location = new System.Drawing.Point(57, 288);
            this.rdoGoalRetirementPlan.Name = "rdoGoalRetirementPlan";
            this.rdoGoalRetirementPlan.Size = new System.Drawing.Size(169, 31);
            this.rdoGoalRetirementPlan.TabIndex = 7;
            this.rdoGoalRetirementPlan.Text = "Retirement Plan";
            this.rdoGoalRetirementPlan.UseVisualStyleBackColor = false;
            // 
            // rdoGoalInvestmentGrowth
            // 
            this.rdoGoalInvestmentGrowth.BackColor = System.Drawing.Color.Green;
            this.rdoGoalInvestmentGrowth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoGoalInvestmentGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGoalInvestmentGrowth.ForeColor = System.Drawing.SystemColors.Control;
            this.rdoGoalInvestmentGrowth.Location = new System.Drawing.Point(57, 245);
            this.rdoGoalInvestmentGrowth.Name = "rdoGoalInvestmentGrowth";
            this.rdoGoalInvestmentGrowth.Size = new System.Drawing.Size(169, 31);
            this.rdoGoalInvestmentGrowth.TabIndex = 8;
            this.rdoGoalInvestmentGrowth.Text = "Investment Growth";
            this.rdoGoalInvestmentGrowth.UseVisualStyleBackColor = false;
            // 
            // pnlFinancialData
            // 
            this.pnlFinancialData.Controls.Add(this.lblFinancialDataTitle);
            this.pnlFinancialData.Controls.Add(this.btnEnter);
            this.pnlFinancialData.Controls.Add(this.lblMonthlyIncome);
            this.pnlFinancialData.Controls.Add(this.txtInvestmentPercentage);
            this.pnlFinancialData.Controls.Add(this.lblExtraIncome);
            this.pnlFinancialData.Controls.Add(this.txtMonthlyIncome);
            this.pnlFinancialData.Controls.Add(this.txtMonthlyExpenses);
            this.pnlFinancialData.Controls.Add(this.lblMonthlyExpenses);
            this.pnlFinancialData.Controls.Add(this.lblInvestmentPercentage);
            this.pnlFinancialData.Controls.Add(this.txtExtraIncome);
            this.pnlFinancialData.Location = new System.Drawing.Point(38, 75);
            this.pnlFinancialData.Name = "pnlFinancialData";
            this.pnlFinancialData.Size = new System.Drawing.Size(291, 500);
            this.pnlFinancialData.TabIndex = 10;
            this.pnlFinancialData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFinancialData_Paint);
            // 
            // pnlGoals
            // 
            this.pnlGoals.Controls.Add(this.lblGoalsTitle);
            this.pnlGoals.Controls.Add(this.rdoGoalFinancialStability);
            this.pnlGoals.Controls.Add(this.rdoGoalInvestmentGrowth);
            this.pnlGoals.Controls.Add(this.rdoGoalEmergencyFund);
            this.pnlGoals.Controls.Add(this.rdoGoalRetirementPlan);
            this.pnlGoals.Controls.Add(this.rdoGoalDebtFree);
            this.pnlGoals.Controls.Add(this.rdoGoalFIRE);
            this.pnlGoals.Location = new System.Drawing.Point(408, 75);
            this.pnlGoals.Name = "pnlGoals";
            this.pnlGoals.Size = new System.Drawing.Size(295, 500);
            this.pnlGoals.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 710);
            this.Controls.Add(this.pnlGoals);
            this.Controls.Add(this.pnlFinancialData);
            this.Controls.Add(this.btnBack);
            this.Name = "Form2";
            this.Text = "-";
            this.pnlFinancialData.ResumeLayout(false);
            this.pnlFinancialData.PerformLayout();
            this.pnlGoals.ResumeLayout(false);
            this.pnlGoals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMonthlyIncome;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblInvestmentPercentage;
        private System.Windows.Forms.Label lblMonthlyExpenses;
        private System.Windows.Forms.Label lblExtraIncome;
        private System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.Label lblFinancialDataTitle;
        private System.Windows.Forms.TextBox txtInvestmentPercentage;
        private System.Windows.Forms.TextBox txtMonthlyExpenses;
        private System.Windows.Forms.TextBox txtExtraIncome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGoalsTitle;
        private System.Windows.Forms.Button rdoGoalFinancialStability;
        private System.Windows.Forms.Button rdoGoalEmergencyFund;
        private System.Windows.Forms.Button rdoGoalDebtFree;
        private System.Windows.Forms.Button rdoGoalFIRE;
        private System.Windows.Forms.Button rdoGoalRetirementPlan;
        private System.Windows.Forms.Button rdoGoalInvestmentGrowth;
        private System.Windows.Forms.Panel pnlFinancialData;
        private System.Windows.Forms.Panel pnlGoals;
    }
}