using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Final_Proj_Csharp_V4
{
    public partial class frmMain : Form
    {
        public string name;
        public frmMain(string name)
        {
            this.name = name;
            InitializeComponent();
            lblWelcome.Text ="Welcome " + name;
        }


        private void btnSpell_Click(object sender, EventArgs e)
        {
            frmSpell frmSpell = new frmSpell(name);
            frmSpell.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit(name);
            frmEdit.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlayGround frmPlayGround = new frmPlayGround(name);
            frmPlayGround.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AskCleanHistory();
            Application.Exit();
        }

        private void AskCleanHistory()
        {
            DialogResult dialogResult = MessageBox.Show("Delete your history?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CleanHistory();
                return;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            throw new Exception("You have to choose yes or no ");
        }

        private void CleanHistory()
        {
            File.WriteAllText(@"..\..\OUTPUT\" + name + "_WrongGame.txt", String.Empty);
            File.WriteAllText(@"..\..\OUTPUT\" + name + "_CorrectGame.txt", String.Empty);
            File.WriteAllText(@"..\..\OUTPUT\" + name + "_WrongSPELLING.txt", String.Empty);
            File.WriteAllText(@"..\..\OUTPUT\" + name + "_CorrectSPELLING.txt", String.Empty);
        }
    }
}
