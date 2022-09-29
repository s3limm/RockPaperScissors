using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class GameMenu : Form
    {

        public string _userName;

        public GameMenu()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void GameMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            lblUserScore.Text = _userName;
        }
    }
}