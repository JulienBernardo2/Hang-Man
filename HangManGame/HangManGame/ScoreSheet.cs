using HangManGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class ScoreSheet : Form
    {
        public ScoreSheet()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainGameMenu obj = new MainGameMenu();
            obj.ShowDialog();
        }

        private void ScoreSheet_Load(object sender, EventArgs e)
        {
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "\\score.txt";
            scoreLabel.Text = File.ReadAllText(filePath, Encoding.UTF8);
        }
    }
}

