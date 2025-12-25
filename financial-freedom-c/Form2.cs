using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financial_freedom_c
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pnlGoals.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu loginForm = Application.OpenForms["Form1"] as MainMenu;

            if (loginForm == null)
            {
                loginForm = new MainMenu();
            }

            loginForm.Show();  
            this.Close();      
        }

        private void pnlFinancialData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            pnlGoals.Enabled = false;

            if (string.IsNullOrWhiteSpace(txtMonthlyIncome.Text) ||
                string.IsNullOrWhiteSpace(txtExtraIncome.Text) ||
                string.IsNullOrWhiteSpace(txtMonthlyExpenses.Text) ||
                cmbInvestmentPercentage.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all financial fields and choose a percentage.",
                                "Missing data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            decimal monthlyIncome;
            decimal extraIncome;
            decimal monthlyExpenses;
            decimal percent;

            if (!decimal.TryParse(txtMonthlyIncome.Text, out monthlyIncome) || monthlyIncome < 0)
            {
                MessageBox.Show("Monthly Income must be a non‑negative number.",
                                "Invalid input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtExtraIncome.Text, out extraIncome) || extraIncome < 0)
            {
                MessageBox.Show("Extra Income must be a non‑negative number.",
                                "Invalid input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonthlyExpenses.Text, out monthlyExpenses) || monthlyExpenses < 0)
            {
                MessageBox.Show("Monthly Expenses must be a non‑negative number.",
                                "Invalid input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }



            

            if (!decimal.TryParse(cmbInvestmentPercentage.SelectedItem.ToString(), out percent) ||
                percent < 0m || percent > 100m)
            {
                MessageBox.Show("Investment Percentage must be between 0 and 100.",
                                "Invalid input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            decimal totalIncome = monthlyIncome + extraIncome;
            decimal savingsCapacity = totalIncome - monthlyExpenses;

            if (savingsCapacity < 0)
            {
                MessageBox.Show("Your expenses are higher than your income.\nYou cannot invest right now.",
                                "Negative balance",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (savingsCapacity == 0)
            {
                MessageBox.Show("You have no money left after expenses.\nThere is nothing to invest this month.",
                                "No savings",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            decimal investmentAmount = savingsCapacity * (percent / 100m);

            FinancialState.MonthlyIncome = monthlyIncome;
            FinancialState.ExtraIncome = extraIncome;
            FinancialState.MonthlyExpenses = monthlyExpenses;
            FinancialState.InvestmentPercentage = percent;
            FinancialState.InvestmentAmount = investmentAmount;

            MessageBox.Show(
                "Your monthly investment amount is: " + investmentAmount.ToString("N2"),
                "Data saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            pnlGoals.Enabled = true;   

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinancialIndependence_Click(object sender, EventArgs e)
        {
            FinancialIndependenceForm frm = new FinancialIndependenceForm();
            frm.ShowDialog();
        }

        private void btnInvestmentGrowth_Click(object sender, EventArgs e)
        {
            InvestmentGrowthForm Frm = new InvestmentGrowthForm();
            Frm.ShowDialog();
        }

        private void btnEmergencyFund_Click(object sender, EventArgs e)
        {
            EmergencyFundForm frm = new EmergencyFundForm();    
            frm.ShowDialog();
        }

        private void btnRetirementPlan_Click(object sender, EventArgs e)
        {
            RetirementPlanForm frm = new RetirementPlanForm();
            frm.ShowDialog();
        }

        private void btnFinancialStability_Click(object sender, EventArgs e)
        {
      
            FinancialStabilityForm frm = new FinancialStabilityForm();
            frm.ShowDialog();

        }


        private void btnDebtFree_Click(object sender, EventArgs e)
        {
            
            DebtFreeForm frm = new  DebtFreeForm();
            frm.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
