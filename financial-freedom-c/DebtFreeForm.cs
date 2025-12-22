using System;
using System.Windows.Forms;

namespace financial_freedom_c
{
    public partial class DebtFreeForm : Form
    {
        private Form2 _form2;
        private double _monthlyPayment;

        public DebtFreeForm(Form2 form2, double monthlyPayment)
        {
            InitializeComponent();
            _form2 = form2;
            _monthlyPayment = monthlyPayment;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double debt;

            if (!double.TryParse(txtDebt.Text, out debt) || debt <= 0)
            {
                MessageBox.Show("Please enter a valid debt amount.");
                return;
            }

            double months = Math.Ceiling(debt / _monthlyPayment);


            lblResult.Text =
                "Total Debt: " + debt + " SAR\n" +
                "Monthly Payment: " + _monthlyPayment + " SAR\n\n" +
                "You will be debt-free in:\n" +
                months + " months";

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

        private void DebtFreeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
