using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HangManGame;

namespace HangManGame
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainGameMenu obj = new MainGameMenu();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
