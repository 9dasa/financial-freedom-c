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
    public partial class InvestmentGrowthForm : Form
    {
        public InvestmentGrowthForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InvestmentGrowthForm_Load(object sender, EventArgs e)
        {
            
            TxtMIValue.Text = FinancialState.InvestmentAmount.ToString("N2");

            
            cmbYears.Items.Clear();
            cmbYears.Items.Add("1");
            cmbYears.Items.Add("2");
            cmbYears.Items.Add("3");
            cmbYears.Items.Add("4");
            cmbYears.Items.Add("5");
            cmbYears.Items.Add("6");
            cmbYears.Items.Add("7");
            cmbYears.Items.Add("8");
            cmbYears.Items.Add("9");
            cmbYears.Items.Add("10");
            cmbYears.Items.Add("11");
            cmbYears.Items.Add("12");
            cmbYears.Items.Add("13");
            cmbYears.Items.Add("14");
            cmbYears.Items.Add("15");
            cmbYears.Items.Add("20");
            cmbYears.Items.Add("25");
            cmbYears.Items.Add("30");

            cmbYears.DropDownStyle = ComboBoxStyle.DropDownList;

            
            TxtMIValue.Text = FinancialState.InvestmentAmount.ToString("N2") + " SAR";

            cmbInterestRate.Items.Clear();

            for (int r = 1; r <= 20; r++)
            {
                cmbInterestRate.Items.Add(r.ToString());
            }
            cmbInterestRate.DropDownStyle = ComboBoxStyle.DropDownList;

            

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          
        
           
            if (cmbYears.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose the number of years.");
                return;
            }

            int years;
            if (!int.TryParse(cmbYears.SelectedItem.ToString(), out years) || years <= 0)
            {
                MessageBox.Show("Years must be a positive number.");
                return;
            }

            if (cmbInterestRate.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an interest rate.");
                return;
            }

            int interestPercent;
            if (!int.TryParse(cmbInterestRate.SelectedItem.ToString(), out interestPercent)
                || interestPercent < 0 || interestPercent > 20)
            {
                MessageBox.Show("Interest rate must be between 1 and 20.");
                return;
            }

            
            decimal monthlyInvestment = FinancialState.InvestmentAmount;
            int months = years * 12;

            
            decimal monthlyRate = (interestPercent / 100m) / 12m;

            decimal totalAmount;

            
            if (monthlyRate == 0)
            {
                totalAmount = monthlyInvestment * months;
            }
            else
            {
                totalAmount =
                    monthlyInvestment *
                    ((decimal)Math.Pow((double)(1 + monthlyRate), months) - 1) / monthlyRate;

            }
            decimal totalInvested = monthlyInvestment * months;
            decimal interestEarned = totalAmount - totalInvested;

            txtResult.Text =
                "Monthly Investment: " + monthlyInvestment.ToString("N2") + " SAR" + Environment.NewLine +
                "Duration: " + years + " years (" + months + " months)" + Environment.NewLine +
                "Interest Rate: " + interestPercent + "%" + Environment.NewLine + Environment.NewLine +
                "Total Invested: " + totalInvested.ToString("N2") + " SAR" + Environment.NewLine +
                "Interest Earned: " + interestEarned.ToString("N2") + " SAR" + Environment.NewLine +
                "Total Future Value: " + totalAmount.ToString("N2") + " SAR";

        }





        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
