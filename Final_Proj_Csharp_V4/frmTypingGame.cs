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
    public partial class frmTypingGame : Form
    {
        public string name;
        int index = 0;
        List<WordGame> words;

        Random rnd = new Random();
        int correct = 0;
        int incorrect = 0;

        public frmTypingGame(string name)
        {
            this.name = name;
            InitializeComponent();
            words = Load3ImageToSpell();
            ShowImage(index, words);
        }


        private List<WordGame> Load3ImageToSpell()
        {
            List<WordGame> words = new List<WordGame>();
            List<int> numbers = new List<int>();
            List<string> wordsuserright = new List<string>();
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
            return words;

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

        private void ShowImage(int index, List<WordGame> ImageToShow)
        {
            txtAnswer.Text = "";
            imageBox.Image = Image.FromFile(words[index].TheImage);
        }


    
        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkAnswer();

        }

        public void checkAnswer()
        {
                if(index == 2)
                {
                MessageBox.Show("Good Job See You Soon");
                this.Close();
                return;
                }
            
                if (txtAnswer.Text == words[index].TheWord)
                {
                    correct++;
                    lblCorrect.Text = "Correct: " + correct.ToString();
                    MessageBox.Show("Well Done!!");
                    index++;
                    AddWordUserCorrect(words[index].id);
                    ShowImage(index, words);
                return;
            }
                else
                {
                    incorrect++;
                    lblWorng.Text = "Incorrect: " + incorrect.ToString();
                    MessageBox.Show("Try Again!!");
                    index++;
                    ShowImage(index, words);
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
        private void checkText(object sender, KeyEventArgs e)
        {
            checkAnswer();

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTypingGame_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            ShowImage(index, words);

        }
    }
}
