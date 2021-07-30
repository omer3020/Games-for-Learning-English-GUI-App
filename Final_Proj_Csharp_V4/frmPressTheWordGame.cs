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
    public partial class frmPressTheWordGame : Form
    {
        public int pointsGain = 0;
        public string name;
        int index = 0;
        List<WordGame> words;
        public List<string> letters = new List<string>();
        public int _ticks = 15;

        public frmPressTheWordGame(string name)
        {
            this.name = name;
            InitializeComponent();
            lblShowTime.Text = _ticks.ToString();
            lblWordPressed.Text = "";
            words = Load3WordToPlay();
            RenderQuestion(index, words);


        }
        private void RenderQuestion(int index, List<WordGame> WordsToShow)
        {
            ShowAllBtn();
            lblWordPressed.Text = "";
            if (index == 3)
            {
                MessageBox.Show("Congratulations you finished the game and scored " + pointsGain + " points");
                this.Close();
                return;
            }
            List<int> randomnumbers = new List<int>();
            while (randomnumbers.Count != words[index].theWord.Length)
            {
                int randomLetter = new Random().Next(0, 19);
                if (!randomnumbers.Contains(randomLetter))
                {
                    randomnumbers.Add(randomLetter);
                }
            }
            pictureBox1.Image = Image.FromFile(words[index].TheImage);
            char[] SplitWord = words[index].theWord.ToCharArray(); 
            var stringChars = CreateCharArray();
            for (int i = 0; i < words[index].theWord.Length; i++)
            {
                stringChars[randomnumbers[i]] = SplitWord[i];
            }
            for (int i = 0; i < 20; i++)
            {
                Button button = (Button)this.Controls["button" + (i+1).ToString()];
                button.Text = stringChars[i].ToString().ToUpper();
            }


        }
        private List<WordGame> Load3WordToPlay()
        {
            List<string> wordsuserright = new List<string>();
            List<WordGame> words = new List<WordGame>();
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


        private void button11_Click(object sender, EventArgs e) //handel all the buttons click events
        {
            var btn = (Button)sender;
            lblWordPressed.Text += btn.Text;
            letters.Add(btn.Text);
            btn.Hide();
            CheckAnswer();

        }
        private void CheckAnswer()
        {
            if (lblWordPressed.Text.ToLower() == words[index].theWord)
            {
                MessageBox.Show("Correct , Well Done");
                pointsGain += 5;
                index++;
                _ticks += 15;
                lblShowPoints.Text = pointsGain.ToString();
                RenderQuestion(index, words);
                AddWordUserCorrect(words[index].id);
            }
            else
            {
                return;
            }
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

        private char[] CreateCharArray()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[20];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return stringChars;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ShowAllBtn();
            lblWordPressed.Text = "";
            letters = new List<string>();
        }

        private void ShowAllBtn()
        {
            for (int i = 0; i < 20; i++)
            {
                Button button = (Button)this.Controls["button" + (i + 1).ToString()];
                button.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            if(_ticks == 0)
            {
                MessageBox.Show("TIME IS UP you finished the game and scored " + pointsGain + " points");
                this.Close();
                return;
            }
            lblShowTime.Text = _ticks.ToString();

        }

        private void lblShowTime_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index == 3)
            {
                index--;
            }
            index++;
            RecordingErrors(words[index].id);
            RenderQuestion(index, words);
        }
    }
}
