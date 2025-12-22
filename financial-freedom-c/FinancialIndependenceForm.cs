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
    public partial class FinancialIndependenceForm : Form
    {
        public FinancialIndependenceForm()
        {
            InitializeComponent();
            LoadDefaultValues();
        }
        private void LoadDefaultValues()
        {
            cmbGrowthRate.Items.Add("3");
            cmbGrowthRate.Items.Add("5");
            cmbGrowthRate.Items.Add("7");
            cmbGrowthRate.SelectedIndex = 0;

           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         
            decimal saving = FinancialState.SavingsCapacity;

            if (saving <= 0)
            {
                MessageBox.Show("Saving capacity must be positive.",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

        
            int years;
            if (!int.TryParse(cmbYears.SelectedItem.ToString(), out years) || years <= 0)
            {
                MessageBox.Show("Please select a valid number of years.");
                return;
            }

            int months = years * 12;

            
            decimal growthRate;
            if (!decimal.TryParse(cmbGrowthRate.SelectedItem.ToString(), out growthRate))
            {
                MessageBox.Show("Invalid growth rate.");
                return;
            }

            growthRate = growthRate / 100m; 

            
            decimal totalAmount = saving * months * (1 + growthRate);

           
            txtResult.Text =
                "Financial Independence Summary:" + Environment.NewLine +
                "--------------------------------------------" + Environment.NewLine +
                $"Monthly Saving: {saving:N2} SAR" + Environment.NewLine +
                $"Duration: {years} years ({months} months)" + Environment.NewLine +
                $"Growth Rate: {growthRate * 100:N0}%" + Environment.NewLine +
                $"Expected Independence Fund: {totalAmount:N2} SAR";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FinancialIndependenceForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
