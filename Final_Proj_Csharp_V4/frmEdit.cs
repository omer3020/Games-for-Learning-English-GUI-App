using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Proj_Csharp_V4
{
    public partial class frmEdit : Form
    {
        string name;
        public frmEdit(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        private void btnAddSpell_Click(object sender, EventArgs e)
        {
            frmAddSpell frmAddSpell = new frmAddSpell(name);
            frmAddSpell.Show();
        }

        private void btnAddToGame_Click(object sender, EventArgs e)
        {
            frmAddWordToGames frmAddWordToGames = new frmAddWordToGames(name);
            frmAddWordToGames.Show();
        }
    }
}
