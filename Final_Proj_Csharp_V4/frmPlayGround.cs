using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Proj_Csharp_V4
{
    public partial class frmPlayGround : Form
    {
        public string name;
        public frmPlayGround(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void frmPlayGround_Load(object sender, EventArgs e)
        {

        }

        private void btnMissingLetter_Click(object sender, EventArgs e)
        {
            frmGameMissingLetter frmGameMissingLetter= new frmGameMissingLetter(name);
            frmGameMissingLetter.Show();
        }

        private void btnImageToWord_Click(object sender, EventArgs e)
        {
            frmTypingGame frmTypingGame = new frmTypingGame(name);
            frmTypingGame.Show();
        }

        private void btnPressTheWord_Click(object sender, EventArgs e)
        {
            frmPressTheWordGame frmPressTheWordGame= new frmPressTheWordGame(name);
            frmPressTheWordGame.Show();
        }

        private void btnSoundToWord_Click(object sender, EventArgs e)
        {
            frmSoundToWord frmSoundToWord = new frmSoundToWord(name);
            frmSoundToWord.Show();
        }
    }
}
