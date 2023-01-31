using HangManGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class SaveScore : Form
    {
        public SaveScore(string score)
        {
            InitializeComponent();
            scoreLabel.Text = score;
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "\\score.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(createTextBox.Text + "\t\t" + scoreLabel.Text);
            }

            this.Hide();
            MainGameMenu obj = new MainGameMenu();
            obj.ShowDialog();
        }

        public string getScore(string score)
        {
            return score;
        }
    }
}
