using HangmanGame;
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

namespace HangManGame
{
    public partial class MainGameMenu : Form
    {
        public String selectedRadio = " ";

        public MainGameMenu()
        {
            InitializeComponent();
            sRadio.Checked = true;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangMan obj = new HangMan(selectedRadio);
            obj.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpWindow obj = new HelpWindow();
            this.Hide();
            obj.ShowDialog();
        }

        private void radioGroup1_Clicked(object sender, EventArgs e)
        {
            if (sRadio.Checked)
            {
                selectedRadio = "s";
            }
            else if (bgRadio.Checked)
            {
                selectedRadio = "bg";
            }
            else
            {
                selectedRadio = "cp";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label5.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch(comboBox1.SelectedIndex)
            {
                case 0: changeLanguage.UpdateConfig("language", "en-CA");
                    Application.Restart();
                    break;

                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;

                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    Application.Restart();
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScoreSheet obj = new ScoreSheet();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
