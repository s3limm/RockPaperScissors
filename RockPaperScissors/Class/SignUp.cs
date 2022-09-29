using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors.Class
{
    internal class SignUp
    {
        string _userName;
        public string userName { 
            get
            {
                return _userName;
            }
            set
            {
                if(value.Length < 4)
                {
                    System.Windows.Forms.MessageBox.Show("Lütfen kullanıcı adınızı 4 harften fazla yapınız.");
                    Application.Restart();
                }
                else
                {
                    _userName = value;
                }
            }
        
        }



        public string passWord { get; set; }
    }
}
