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

    }
}
