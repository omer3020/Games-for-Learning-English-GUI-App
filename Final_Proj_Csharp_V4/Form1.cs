using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proj_Csharp_V4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email must be entered");
                return;
            }
            else
            {
                CheckEmail();
            }
        }
        //extract the name of the user from the email he\she enterd

        private string ExtractName(string email)
        {
            string[] Splitted = email.Split('@');
            return Splitted[0];
        }
        private void OpenMainForm(string email)
        {
            string name = ExtractName(email);
            User user1 = new User(name, email);
            frmMain frmMain = new frmMain(name);
            frmMain.Show();
            this.Hide();
        }

        

        //Checks if the email the user entered is a valid address
        private void CheckEmail()
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                OpenMainForm(email);

            }
            else
            {
                MessageBox.Show("Invalid email");

            }
        }
    }
}
