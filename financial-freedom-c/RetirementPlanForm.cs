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
    public partial class RetirementPlanForm : Form
    {
        public RetirementPlanForm()
        {
            InitializeComponent();
        }
        private void RetirementPlanForm_Load(object sender, EventArgs e)
        {
            
            label.Text = FinancialState.InvestmentAmount.ToString("N2");

            
            cmbYears.Items.Clear();
            for (int i = 1; i <= 40; i++)
                cmbYears.Items.Add(i.ToString());

            
            cmbGrowth.Items.Clear();
            for (int i = 1; i <= 15; i++)
                cmbGrowth.Items.Add(i.ToString());

            cmbYears.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrowth.DropDownStyle = ComboBoxStyle.DropDownList;

            txtResult.Text = "";
        }
        private void lblMonthlySavingValue_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            if (cmbYears.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the number of years.");
                return;
            }

            
            if (cmbGrowth.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a growth rate.");
                return;
            }

            
            int years = int.Parse(cmbYears.SelectedItem.ToString());
            int months = years * 12;

            decimal growth = decimal.Parse(cmbGrowth.SelectedItem.ToString());
            decimal monthlySaving = FinancialState.InvestmentAmount;

            
            decimal totalFund = monthlySaving * months * (1 + (growth / 100));

              
            txtResult.Text =
                "Retirement Plan Summary:" + Environment.NewLine +
                "-------------------------------------" + Environment.NewLine +
                "Monthly Saving: " + monthlySaving.ToString("N2") + " SAR" + Environment.NewLine +
                "Duration: " + years + " years (" + months + " months)" + Environment.NewLine +
                "Growth Rate: " + growth + "%" + Environment.NewLine +
                "Expected Retirement Fund: " + totalFund.ToString("N2") + " SAR" + Environment.NewLine +
                "-------------------------------------";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblMonthlySavingValue_Click_1(object sender, EventArgs e)
        {

        }
    }
}
