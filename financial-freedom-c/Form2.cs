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

            // 1) Check that all fields and the percentage are filled/selected
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

            // 2) Read and validate numbers
            decimal monthlyIncome;
            decimal extraIncome;
            decimal monthlyExpenses;
            decimal percent;

            // If the user enters text (like "abc"), TryParse will fail => invalid
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



            // percentage comes from the ComboBox
            

            if (!decimal.TryParse(cmbInvestmentPercentage.SelectedItem.ToString(), out percent) ||
                percent < 0m || percent > 100m)
            {
                MessageBox.Show("Investment Percentage must be between 0 and 100.",
                                "Invalid input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            // 3) Calculate savings capacity
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

            // 4) Positive savings → calculate investment amount
            decimal investmentAmount = savingsCapacity * (percent / 100m);

            // 5) Store everything in FinancialState for later goal screens
            FinancialState.MonthlyIncome = monthlyIncome;
            FinancialState.ExtraIncome = extraIncome;
            FinancialState.MonthlyExpenses = monthlyExpenses;
            FinancialState.InvestmentPercentage = percent;
            FinancialState.InvestmentAmount = investmentAmount;

            // 6) Inform the user and enable the goals panel
            MessageBox.Show(
                "Your monthly investment amount is: " + investmentAmount.ToString("N2"),
                "Data saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            pnlGoals.Enabled = true;   // now the user can pick a goal

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinancialIndependence_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInvestmentGrowth_Click(object sender, EventArgs e)
        {
            InvestmentGrowthForm Frm = new InvestmentGrowthForm();
            Frm.ShowDialog();
        }
    }
}
