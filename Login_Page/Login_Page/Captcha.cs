using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class Captcha : Form
    {
        public Captcha()
        {
            InitializeComponent();
            lbl_cap.Text = getCaptcha();
        }
        Random random = new Random();   
        Dashboard ds=new Dashboard();   
        private void btn_check_Click(object sender, EventArgs e)
        {
            if(lbl_cap.Text == txt_check.Text)
            {
                ds.Show();
                this.Hide();
            }
            else
            {
                lbl_mes.Text = "You didn't pass captcha!Try again";
                lbl_cap.Text = "";
                lbl_cap.Text = getCaptcha();

            }
        }
        internal string getCaptcha()
        {
            string captcha = "";
            for (int i = 0; i < random.Next(6, 10); i++)
            {
                if (random.Next(2) % 2 == 0)
                {
                    captcha += char.ConvertFromUtf32(random.Next(65, 91));
                    continue;
                }
                captcha += char.ConvertFromUtf32(random.Next(48, 58));
            }
            return captcha;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void Captcha_Load(object sender, EventArgs e)
        {

        }
    }
}
