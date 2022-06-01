using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_1._0
{
    public partial class Login : Form
    {
        int isMoreTry = 0, timer = 0;
        public bool isSuccessPass = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (isMoreTry < 3)
                {
                    if (txtUserName.Text == "admin" && txtPassword.Text == "1234")
                        DialogResult = DialogResult.OK;
                    else
                        isMoreTry++;
                }
                else
                {
                    MessageBox.Show("Please wait 1 minute");
                    btnLogin.Enabled = false;
                }
            }
            else
                MessageBox.Show("Please fill fields");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if(timer >= 60)
            {
                btnLogin.Enabled = true;
                MessageBox.Show("Try again");
                timer1.Enabled = false;
                timer1.Stop();
                isMoreTry = 0;
            }
        }
    }
}
