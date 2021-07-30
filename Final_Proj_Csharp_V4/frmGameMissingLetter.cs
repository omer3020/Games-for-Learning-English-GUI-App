using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Final_Proj_Csharp_V4
{
    public partial class frmGameMissingLetter : Form
    {
        string missingLetter;
        public int pointsGain = 0;
        public string name;
        int index = 0;
        List<WordGame> words;
        SoundPlayer player = new SoundPlayer();

        public frmGameMissingLetter(string name )
        {
            this.name = name;
            InitializeComponent();
            words = Load3WordToPlay();
            ShowQuestion(index, words);

        }
        private void ShowQuestion(int index, List<WordGame> WordsToShow)
        {
            int randomLetter = new Random().Next(0, words[index].theWord.Length-1);
            char[] newWord = words[index].theWord.ToCharArray();
            missingLetter = newWord[randomLetter].ToString();
            newWord[randomLetter] = '_';
            string WordToShow = new string(newWord);
            lblWord.Text = WordToShow;
            player = new SoundPlayer(words[index].Sound);
            //pictureBox1.ImageLocation = words[index].TheImage;
            pictureBox1.Image = Image.FromFile(words[index].TheImage);
        }
        private List<WordGame> Load3WordToPlay()
        {
            List<WordGame> words = new List<WordGame>();
            List<string> wordsuserright = new List<string>();
            List<int> numbers = new List<int>();
            string[] lines = File.ReadAllLines(@"..\..\DATA\wordImageData.txt");

            wordsuserright = WordsUserRight();
            numbers = CheckUserWorngAnswer(wordsuserright);
            while (numbers.Count != 3)
            {
                int random_number = new Random().Next(0, lines.Length - 1);
                if (!numbers.Contains(random_number) && !wordsuserright.Contains(random_number.ToString()))
                {
                    numbers.Add(random_number);
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                string word = lines[numbers[i]];
                string[] splitword = word.Split(";");
                WordGame wordGame = new WordGame(splitword[0], splitword[1], splitword[3], splitword[2], splitword[4], splitword[5], splitword[6]);
                words.Add(wordGame);
            }
            player = new SoundPlayer(words[index].Sound);
            return words;
        }
        //Returns the words that the user was right so that we do not see the same questions..
        private List<string> WordsUserRight()
        {
            List<string> wordsRight = new List<string>();
            string filename = @"..\..\OUTPUT\" + name + "_CorrectGame.txt";
            using (StreamWriter w = File.AppendText(filename)) //create the file if it doesn't exist and open the file for appending
                w.Close();
            string text = File.ReadAllText(filename);
            if (string.IsNullOrEmpty(text)) //if its a new user
            {
                return wordsRight; // user is new a he dont have any worng questions
            }
            string[] splittext = text.Split(";");
            foreach (string num in splittext)
            {
                wordsRight.Add(num);
            }
            return wordsRight;

        }

        //Checks if the user has questions he has mistaken and if so adds them to the list and will answer them again
        private List<int> CheckUserWorngAnswer(List<string> wordsuserright)
        {
            List<int> numbers = new List<int>();
            string filename = @"..\..\OUTPUT\" + name + "_WrongGame.txt";
            using (StreamWriter w = File.AppendText(filename)) //create the file if it doesn't exist and open the file for appending
                w.Close();
            string text = File.ReadAllText(filename);
            if (string.IsNullOrEmpty(text)) //if its a new user
            {
                return numbers; // user is new a he dont have any worng questions
            }
            string[] splittext = text.Split(";");
            for (int i = 1; i < splittext.Length - 1; i++)
            {
                if (numbers.Count == 5)
                {
                    return numbers;
                }
                if (!wordsuserright.Contains(splittext[i]))
                {
                    numbers.Add(Int32.Parse(splittext[i]));

                }
            }

            return numbers;
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (index == 2)
            {
                MessageBox.Show("Congratulations you finished the game and scored " +pointsGain+ " points");
                this.Close();
                return;
            }
            CheckAnswer();
            index++;
            ShowQuestion(index, words);
        }
        private void CheckAnswer()
        {
            if (txtInput.Text == "" || txtInput.Text.Length != 1)
            {
                MessageBox.Show("Must fill in the field with the missing letter");
                index--;
                txtInput.Text = "";
                return;
            }
            if(txtInput.Text.ToLower() == missingLetter)
            {
                pointsGain += 5;
                MessageBox.Show("Correct , Well Done");
                txtInput.Text = "";
                lblShowPoints.Text = pointsGain.ToString();
                AddWordUserCorrect(words[index].id);
                return;
            }
            if (txtInput.Text != missingLetter)
            {
                MessageBox.Show("Worng , try your best next time");
                txtInput.Text = "";
                RecordingErrors(words[index].id);
                return;
            }
        }


        //Recording user errors in a file unique to him
        //points;worderrorid1;worderrorid2;worderrorid3.......
        private void RecordingErrors(string id)
        {
            string filename = @"..\..\OUTPUT\" + name + "_WrongGame.txt";
            using (StreamWriter w = File.AppendText(filename)) //create the file if it doesn't exist and open the file for appending
                w.Close();
            string text = File.ReadAllText(filename);
            if (string.IsNullOrEmpty(text)) //if its a new user
            {
                text = "0;" + id + ";";
                using (StreamWriter writer = new StreamWriter(filename, true)) // true to append data to the file
                {
                    writer.Write(text);
                    writer.Close();
                }
                return;
            }
            //if its an old user
            string newtext;
            string[] splittext = text.Split(";");
            //Checks that there are no duplicates in a text file 
            if (CheckForDuplicates(splittext, id))
            {
                return;
            }
            newtext = string.Join(";", splittext);
            File.WriteAllText(filename, string.Empty); // clear thr file
            newtext = newtext + id + ";";
            using (StreamWriter writer = new StreamWriter(filename, true)) // true to append data to the file
            {
                writer.Write(newtext); // add the updated content to file 
                writer.Close();
            }
            return;
        }
        //Checks that there are no duplicates in a text file 
        private bool CheckForDuplicates(string[] splittext, string id)
        {
            foreach (var letter in splittext)
            {
                if (letter == id)
                {
                    return true;
                }
            }
            return false;
        }

        //add the id of the word user correct
        private void AddWordUserCorrect(string wordId)
        {
            string filename = @"..\..\OUTPUT\" + name + "_CorrectGame.txt";
            using (StreamWriter w = File.AppendText(filename)) //create the file if it doesn't exist and open the file for appending
                w.Close();
            string text = File.ReadAllText(filename);
            using (StreamWriter writer = new StreamWriter(filename, true)) // true to append data to the file
            {
                writer.Write(wordId + ";"); // add the updated content to file 
                writer.Close();
            }
            return;
        }

        private void frmGameMissingLetter_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
