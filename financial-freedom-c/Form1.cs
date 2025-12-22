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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.Show();
            this.Hide();                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

