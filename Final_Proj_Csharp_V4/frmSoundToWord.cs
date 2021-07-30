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
    public partial class frmSoundToWord : Form
    {
        public string name;
        int index = 0;
        public int pointsGain = 0;
        int correct = 0;
        int incorrect = 0;
        List<WordWSpelling> words;
        SoundPlayer player = new SoundPlayer();


        public frmSoundToWord(string name)
        {
            this.name = name;
            InitializeComponent();
            words = Load5WordToSpell();
            ShowQuestion(index, words);
        }
        private List<WordWSpelling> Load5WordToSpell()
        {
            List<string> wordsuserright = new List<string>();
            List<WordWSpelling> words = new List<WordWSpelling>();
            List<int> numbers = new List<int>();
            string[] lines = File.ReadAllLines(@"..\..\DATA\SpellWords.txt");

            wordsuserright = WordsUserRight();
            numbers = CheckUserWorngAnswer(wordsuserright);
            while (numbers.Count != 5 )
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
                WordWSpelling wordWSpelling = new WordWSpelling(splitword[0], splitword[1], splitword[2], splitword[3], splitword[4], splitword[5]);
                words.Add(wordWSpelling);
            }
            player = new System.Media.SoundPlayer(words[index].Sound);
            return words;

        }
        //Returns all words that the user made a mistake
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


        //reder the Question to user
        private void ShowQuestion(int index, List<WordWSpelling> WordsToShow)
        {
            radioButton1.Text = WordsToShow[index].Worng1;
            radioButton2.Text = WordsToShow[index].Worng2;
            radioButton4.Text = WordsToShow[index].Worng3;
            radioButton3.Text = WordsToShow[index].theWord;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            if (btnNext.Text == "Finish")
            {
                MessageBox.Show("You have successfully completed the practice and you gained " + pointsGain + " points");
                this.Close();
                return;
            }
            UncheckButtons();
            index++;
            if (index > 3)
            {
                btnNext.Text = "Finish";
            }
            player = new SoundPlayer(words[index].Sound);
            ShowQuestion(index, words);
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

        //Check if the Answer is correct
        private void CheckAnswer()
        {
            if (radioButton3.Checked)
            {
                MessageBox.Show("Congratulations you answered correctly");
                pointsGain += 5;
                correct++;
                RenderCorrect();
                Add5Points(words[index].id);
                AddWordUserCorrect(words[index].id);
                return;
            }

            if (!radioButton3.Checked)
            {
                MessageBox.Show("wrong answer");
                incorrect++;
                RenderIncorrect();
                RecordingErrors(words[index].id);
                return;
            }

            if ((radioButton1.Checked == false || radioButton2.Checked == false || radioButton3.Checked == false || radioButton4.Checked == false))
            {
                MessageBox.Show("One of the answers must be filled out");
                index--;
                return;
            }
        }


        //Uncheck Buttons
        private void UncheckButtons()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        //play the sound
        private void btnSound_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            UncheckButtons();
        }


        //Recording user errors in a file unique to him
        //points;worderrorid1;worderrorid2;worderrorid3.......
        private void RecordingErrors(string id)
        {
            string filename = @"..\..\OUTPUT\" + name + "_WrongSPELLING.txt";
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
            if (CheckForDupli(splittext, id))
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

        private void Add5Points(string id)
        {
            string filename = @"..\..\OUTPUT\" + name + "_WrongSPELLING.txt";
            using (StreamWriter w = File.AppendText(filename)) //create the file if it doesn't exist and open the file for appending
                w.Close();
            string text = File.ReadAllText(filename);
            if (string.IsNullOrEmpty(text)) //if its a new user
            {
                text = "5;" + id + ";";
                using (StreamWriter writer = new StreamWriter(filename, true)) // true to append data to the file
                {
                    writer.Write(text);
                    writer.Close();
                }
                return;
            }
            //if its an old user
            string newtext;
            string points;
            string[] splittext = text.Split(";");
            points = (Int32.Parse(splittext[0]) + 5).ToString();
            splittext[0] = points;
            newtext = string.Join(";", splittext);
            File.WriteAllText(filename, string.Empty); // clear thr file
            using (StreamWriter writer = new StreamWriter(filename, true)) // true to append data to the file
            {
                writer.Write(newtext); // add the updated content to file 
                writer.Close();
            }
            return;


        }

        //Checks that there are no duplicates in a text file 
        private bool CheckForDupli(string[] splittext, string id)
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


        //render the correct answer to the screen
        private void RenderCorrect()
        {
            lblCorrect.Text = "Correct: " + correct;
        }

        //render the Incorrect answer to the screen
        private void RenderIncorrect()
        {
            lblWorng.Text = "Incorrect: " + incorrect;
        }

    }
}
