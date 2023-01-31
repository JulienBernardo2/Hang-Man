using HangManGame;
using HangManGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class HangMan : Form
    {
        private int guessesLeft = 6;
        public string currentWord;
        private int duration = 61;
        char[] rightGuess = new char[100];
        string language = ConfigurationManager.AppSettings["language"];

        private string GetWord(string selectedRadio)
        {
            int i = 0;
            string words = Resources.sports;

            if (selectedRadio == "s" && language == "en-CA")
            {
                words = Resources.sports;
            }
            else if(selectedRadio == "bg" && language == "en-CA")
            {
                words = Resources.boardGames;
            }
            else if(selectedRadio == "cp" && language == "en-CA")
            {
                words = Resources.computerScience;
            }

            else if (selectedRadio == "s" && language == "fr-CA")
            {
                words = Resources.sportFR;
            }
            else if (selectedRadio == "bg" && language == "fr-CA")
            {
                words = Resources.boardGamesFR;
            }
            else if (selectedRadio == "cp" && language == "fr-CA")
            {
                words = Resources.computerScienceFR;
            }

            else if (selectedRadio == "s" && language == "es")
            {
                words = Resources.sportsES;
            }
            else if (selectedRadio == "bg" && language == "es")
            {
                words = Resources.boardGameES;
            }
            else if (selectedRadio == "cp" && language == "es")
            {
                words = Resources.computerScienceES;
            }

            List<string> wordList = new List<string>();
            string a = "";
            char[] fun = new char[100];
            foreach (char word in words)
            {
                if (word == '\n')
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        a += fun[j];
                    }
                    wordList.Add(a);
                    a = "";
                    i = 0;
                }
                else
                {
                    fun[i] = word;
                    i++;
                }

            }
            Random rnd = new Random();
            int index = rnd.Next(0, wordList.Count);

            return wordList[index];
        }

        private void change_Image()
        {
            guessesLeft = (guessesLeft - 1);
            pictureBox.Image = (Image)(Resources.ResourceManager.GetObject($"hangman_{guessesLeft}"));
        }

        public HangMan(string selectedRadio)
        {
            InitializeComponent();
            currentWord = GetWord(selectedRadio);
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            char[] guess = new char[currentWord.Length];
            pictureBox.Image = Resources.hangman_6; 
            for (int i = 0; i < currentWord.Length; i++)
            {
                guess[i] = '*';
                wordLabel.Text = wordLabel.Text + guess[i] + " ";
                rightGuess[i] = '*';
            }

            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void check_Win()
        {
            int lettersLeft = 0;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (rightGuess[i] == '*')
                {
                    lettersLeft++;
                }

            }
            if (lettersLeft == 0)
            {
                timer1.Stop();
                string score = checkScore();
                if (language == "en-CA")
                {
                    DialogResult DR = MessageBox.Show("YOU WON WITH A SCORE OF " + score + "!!\nCreate Your Account to save your score", "Congratulations", MessageBoxButtons.OK);
                    if (DR == DialogResult.OK)
                    {
                        this.Hide();
                        SaveScore obj = new SaveScore(score);
                        obj.ShowDialog();
                    }
                }
                
                else if (language == "fr-CA")
                {
                    DialogResult DR = MessageBox.Show("VOUS AVEZ GAGNÉ AVEC UN SCORE DE " + score + "!!\nCréez votre compte pour enregistrer votre score", "Félicitations", MessageBoxButtons.OK);
                    if (DR == DialogResult.OK)
                    {
                        this.Hide();
                        //CreateAccount obj = new CreateAccount();
                        //obj.ShowDialog();
                    }
                }
                
                else if (language == "es")
                {
                    DialogResult DR = MessageBox.Show("GANÓ CON UNA PUNTUACIÓN DE " + score + "!!\nCrea tu cuenta para guardar tu puntuación", "Felicidades", MessageBoxButtons.OK);
                    if (DR == DialogResult.OK)
                    {
                        this.Hide();
                        //CreateAccount obj = new CreateAccount();
                        //obj.ShowDialog();
                    }
                }
            }
        }
        private void check_lose()
        {
            if (guessesLeft == 0 || timeLeft.Text == "0")
            {
                timer1.Stop();
                wordLabel.Text = currentWord.ToUpper();
                if(language == "en-CA")
                {
                    DialogResult DR = MessageBox.Show("Try again", "You lost", MessageBoxButtons.OK);
                    if(DR == DialogResult.OK)
                    {
                        this.Hide();
                    MainGameMenu obj = new MainGameMenu();
                    obj.ShowDialog();
                    }   
                }
                else if (language == "fr-CA")
                {
                    DialogResult DR = MessageBox.Show("Réessayer", "Tu as perdu", MessageBoxButtons.OK);
                    if (DR == DialogResult.OK)
                    {
                        this.Hide();
                        MainGameMenu obj = new MainGameMenu();
                        obj.ShowDialog();
                    }
                }
                else if (language == "es")
                {
                    DialogResult DR = MessageBox.Show("Rever", "Perdiste", MessageBoxButtons.OK);
                    if (DR == DialogResult.OK)
                    {
                        this.Hide();
                        MainGameMenu obj = new MainGameMenu();
                        obj.ShowDialog();
                    }
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
          
            char[] guess = new char[currentWord.Length];
            Button button = (Button)sender;
            bool matched = false;
            char guessed = Convert.ToChar(button.Text);
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i] == (guessed + 32))
                {
                    rightGuess[i] = guessed;
                    matched = true;
                }
            }
            if (matched == false)
            {
                change_Image();
            }
            wordLabel.Text = "";
            for (int i = 0; i < currentWord.Length; i++)
            {
                wordLabel.Text += Convert.ToString(rightGuess[i]) + " ";
            }
            button.Enabled = false;
            check_lose();
            check_Win();
        }
        private void count_down(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                timer1.Stop();
                check_lose();
            }
            else if (duration > 0)
            {
                duration--;
                timeLeft.Text = duration.ToString();
            }
        }

        private String checkScore()
        {
            int scoreResult = duration * 4;
            return scoreResult.ToString();
        }
    }   
}
