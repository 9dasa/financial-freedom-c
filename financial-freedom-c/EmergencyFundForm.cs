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
    public partial class EmergencyFundForm : Form
    {
        public EmergencyFundForm()
        {
            InitializeComponent();
        }
        private void EmergencyFundForm_Load(object sender, EventArgs e)
        {
            
            lblExpensesValue.Text = FinancialState.MonthlyExpenses.ToString("N2");

            
            cmbMonths.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cmbMonths.Items.Add(i.ToString());
            }

            cmbMonths.DropDownStyle = ComboBoxStyle.DropDownList;
            txtResult.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            if (cmbMonths.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the number of months.",
                    "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int months;
            if (!int.TryParse(cmbMonths.SelectedItem.ToString(), out months) || months <= 0)
            {
                MessageBox.Show("Invalid duration.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            decimal monthlyExpenses = FinancialState.MonthlyExpenses;
            decimal requiredFund = monthlyExpenses * months;

            
            txtResult.Text =
                "Monthly Expenses: " + monthlyExpenses.ToString("N2") + Environment.NewLine +
                "Duration: " + months + " months" + Environment.NewLine +
                "Required Emergency Fund: " + requiredFund.ToString("N2") + " SAR";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyFundForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

