using System;
using System.Windows.Forms;

namespace financial_freedom_c
{
    public partial class FinancialStabilityForm : Form
    {
        private Form2 _form2;
        private double _monthlySaving;

        public FinancialStabilityForm(Form2 form2, double monthlySaving)
        {
            InitializeComponent();
            _form2 = form2;
            _monthlySaving = monthlySaving;
        }

        private void FinancialStabilityForm_Load(object sender, EventArgs e)
        {

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
            cmbYears.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_monthlySaving <= 0)
            {
                MessageBox.Show("Your monthly saving capacity is 0. Check income/expenses in Form2.");
                return;
            }

            if (cmbYears.SelectedItem == null)
            {
                MessageBox.Show("Select number of years.");
                return;
            }

            int years = int.Parse(cmbYears.SelectedItem.ToString());
            int months = years * 12;

            double totalSaved = _monthlySaving * months;

            lblResult.Text =
                "Financial Stability Summary:\n" +
                "---------------------------\n" +
                "Monthly Saving Capacity: " + _monthlySaving.ToString("0.00") + " SAR\n" +
                "Duration: " + years + " years (" + months + " months)\n\n" +
                "Expected Savings: " + totalSaved.ToString("0.00") + " SAR";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _form2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FinancialStabilityForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
