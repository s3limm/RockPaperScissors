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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] items = { "Rock", "Paper", "Scissors" };
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                cmbİtems.Items.Add(items[i]);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

            lblUs.Text = cmbİtems.SelectedItem.ToString();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            string enemy = lblEnemy.Text;
            string us = lblUs.Text;

            Random random = new Random();    //rock paper scissors 
            int enemyGuess = random.Next(0, 3);
            lblEnemy.Text = items[enemyGuess];

            if ((enemy == items[0] && us == items[1]) || (enemy == items[1] && us == items[2]) || (enemy == items[2] && us == items[0])) //we won
            {
                MessageBox.Show("You Won !!!");
                Application.Restart();
            }

            else if ((enemy == items[1] && us == items[0]) || (enemy == items[2] && us == items[1]) || (enemy == items[0] && us == items[2]))
            {
                MessageBox.Show("We Won !!!");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Draw !!!");
                Application.Restart();
            }
        }


    }
}