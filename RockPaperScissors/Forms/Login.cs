using RockPaperScissors.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors.Forms
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SignUp signUp = new SignUp();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreinizi giriniz.");
            }

            else if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı veya şifrenizi boş bırakmayınız.");
            }
            else
            {
                signUp.userName = txtUserName.Text;
                signUp.passWord = txtPassword.Text;
                GameMenu gameMenu = new GameMenu();
                gameMenu._userName = signUp.userName;
                gameMenu.Show();
                this.Hide();
            }
        }
    }
}
