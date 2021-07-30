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
    public partial class frmAddWordToGames : Form
    {
        public frmAddWordToGames(string name)
        {
            InitializeComponent();
        }

        private void btnAddGameWord_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                throw new Exception("One or more of the fields is incomplete");
               
            }
            //if fields are full we add the new word to the text file
            AddSpellWordToFile();

        }

        private bool CheckFields()
        {
            if (string.IsNullOrEmpty(txtWord.Text) || string.IsNullOrEmpty(lblBrowseSound.Text) || string.IsNullOrEmpty(lblBrowseImage.Text))
            {
                return true;
            }
            return false;
        }

        private void AddSpellWordToFile()
        {
            string newLine;
            string word = txtWord.Text;

            if (CheckIfWordExists(word))
            {
                throw new Exception("Word Is already Exists");
            }

            string number = ((Int32.Parse(GetLastNumber()) + 1).ToString());
            string[] voice = lblBrowseSound.Text.Split(@"\");
            string[] image = lblBrowseImage.Text.Split(@"\");
            string voicefile = @"..\..\VOICE\" + voice[voice.Length - 1];
            string imagefile = @"..\..\DIMAGES\" + image[image.Length - 1];

            if (!CheckIfFileIsWav(voice[voice.Length - 1]) && !CheckIfFileIsImg(image[image.Length - 1]))
            {
                throw new Exception("voice file Is not .wav type or Image file is not .jpg/.jpeg type");

            }


            char[] wordSplit = word.ToCharArray();//split word to chars
            char firstletter = wordSplit[0];
            char secondletter = wordSplit[1];
            char thirdletter = wordSplit[2];
            newLine = number + ";" + word + ";" + imagefile + ";" + voicefile + ";" + firstletter + ";" + secondletter + ";" + thirdletter;
            File.AppendAllText(@"..\..\DATA\wordImageData.txt", newLine + Environment.NewLine);
            File.Move(lblBrowseSound.Text, @"..\..\VOICE\" + word + ".wav", true); // true for overwriteing
            File.Move(lblBrowseImage.Text, @"..\..\DIMAGES\" + word + ".jpg", true); // true for overwriteing
            MessageBox.Show("The item was added successfully");
            this.Close();
        }

        private bool CheckIfWordExists(string word)
        {
            string[] lines = File.ReadAllLines(@"..\..\DATA\wordImageData.txt");
            string readword;
            if (lines.Length == 0)
            {
                return false; //returns false if there is no lines in the file
            }
            for (int i = 0; i < lines.Length; i++)
            {
                string[] splitLine = lines[i].Split(";");
                readword = splitLine[1];
                if (readword == word)
                {
                    return true;
                }
            }
            return false;

        }
        private string GetLastNumber()
        {
            string[] lines = File.ReadAllLines(@"..\..\DATA\wordImageData.txt", Encoding.UTF8);
            if (lines.Length == 0)
            {
                return "-1";
            }
            string lastLine = lines[lines.Length - 1];
            string[] splitLine = lastLine.Split(";");
            return splitLine[0];

        }
        private bool CheckIfFileIsWav(string file)
        {
            string[] split = file.Split(@".");
            if (split[1] == "wav")
            {
                return true;
            }
            return false;

        }
        
        private bool CheckIfFileIsImg(string file)
        {
            string[] split = file.Split(@".");
            if (split[1] == "jpg" || split[1] == "jpeg")
            {
                return true;
            }
            return false;

        }
        private void frmAddWordToGames_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseSoundFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string path = dialog.FileName;
                lblBrowseSound.Text = path;
            }
        }

        private void btnBrowseImgFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                string path = dialog.FileName;
                lblBrowseImage.Text = path;
            }
        }
    }
}
