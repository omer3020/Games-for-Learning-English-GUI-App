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
    public partial class frmAddSpell : Form
    {
        public string name;
        public frmAddSpell(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        private void btnAddSpellWord_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                MessageBox.Show("One or more of the fields is incomplete");
                return;
            }
            //if fields are full we add the new word to the text file
            AddSpellWordToFile();

        }
        //returns the last word number in the file
        private string GetLastNumber()
        {
            string[] lines = File.ReadAllLines(@"..\..\DATA\SpellWords.txt", Encoding.UTF8);
            if(lines.Length == 0)
            {
                return "-1";
            }
            string lastLine = lines[lines.Length-1];
            string[] splitLine = lastLine.Split(";");
            return splitLine[0];

        }
        
        //add the word to file
        private void AddSpellWordToFile()
        {
            string newLine;
            string word = txtWord.Text;

            if (CheckIfWordExists(word))
            {
                throw new Exception("Word Is already Exists");
            }

            string number = ((Int32.Parse(GetLastNumber())+1).ToString());         
            string[] voice = lblBrowse.Text.Split(@"\");
            string file = @"..\..\VOICE\"+ voice[voice.Length-1];

            if(!CheckIfFileIsWav(voice[voice.Length - 1]))
            {
                throw new Exception("file Is not .wav type");

            }
            string Worng1 = txtWorng1.Text;
            string Worng2 = txtWorng2.Text;
            string Worng3 = txtWorng3.Text;
            newLine = number + ";" + word + ";" + file + ";" + Worng1 + ";" + Worng2 + ";" + Worng3;
            File.AppendAllText(@"..\..\DATA\SpellWords.txt", newLine + Environment.NewLine);
            File.Move(lblBrowse.Text, @"..\..\VOICE\" + word+".wav", true); // true for overwriteing
            MessageBox.Show("The item was added successfully");
            this.Close();
        }

        //Check If the file is wav file; return true if is wav otherwise false
        private bool CheckIfFileIsWav(string file)
        {
            string[] split = file.Split(@".");
            if(split[1] == "wav")
            {
                return true;
            }
            return false;

        }
        //Check If the Word is already Exists; return true if the word is in the file otherwise false
        private bool CheckIfWordExists(string word)
        {
            string[] lines = File.ReadAllLines(@"..\..\DATA\SpellWords.txt");
            string readword;
            if (lines.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < lines.Length; i++)
            {
                string[] splitLine = lines[i].Split(";");
                readword = splitLine[1];
                if(readword == word)
                {
                    return true;
                }
            }
            return false;

        }

        //check if one or more of the fields are empty
        private bool CheckFields()
        {
            if (string.IsNullOrEmpty(txtWord.Text) || string.IsNullOrEmpty(txtWorng1.Text) || string.IsNullOrEmpty(txtWorng2.Text) || string.IsNullOrEmpty(txtWorng3.Text) || string.IsNullOrEmpty(lblBrowse.Text))
            {
                return true;
            }
            return false;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string path = dialog.FileName;
                lblBrowse.Text = path;
            }
        }

        private void txtWorng2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
