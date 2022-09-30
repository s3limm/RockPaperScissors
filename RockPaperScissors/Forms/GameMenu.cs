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
        string[] options = { "R", "P", "S" };
        string playerChoise;
        string cpuChoise;
        Random random = new Random();
        public int integer = 6;
        public GameMenu()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            integer--;
            lblCounting.Text = integer.ToString();
        }
        private void MakingChoise(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            playerChoise = (string)btn.Tag;
            timer1.Start();

            int i = random.Next(0, 3);
            cpuChoise = options[i];

            lblUserChoise.Text = $"{_userName}'s Choise is:" + TextAndPictureEvent(playerChoise, picUser);


            lblCpuChoise.Text = "Cpu's Choise is:" + TextAndPictureEvent(cpuChoise, picCpu);

        }


        private string TextAndPictureEvent(string text, PictureBox pic)
        {
            string word = null;
            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.ROCK;
                    break;

                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.PAPER;
                    break;

                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
            }
            return word;
        }


    }
}