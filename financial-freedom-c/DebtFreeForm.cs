using System;
using System.Windows.Forms;

namespace financial_freedom_c
{
    public partial class DebtFreeForm : Form
    {
        
        public DebtFreeForm()
        {
            InitializeComponent();
            
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDebt.Text, out decimal debt) || debt <= 0)
            {
                MessageBox.Show("Please enter a valid debt amount.");
                return;
            }

            if (!decimal.TryParse(txtPayment.Text, out decimal payment) || payment <= 0)
            {
                MessageBox.Show("Please enter a valid monthly payment.");
                return;
            }

            
            double months = Math.Ceiling((double)(debt / payment));

            lblResult.Text =
                "Total Debt: " + debt.ToString("N2") + " SAR\n" +
                "Monthly Payment: " + payment.ToString("N2") + " SAR\n\n" +
                "You will be debt-free in:\n" +
                months + " months";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DebtFreeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
