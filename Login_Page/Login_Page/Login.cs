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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            Account ac = Db_Class.account_login(txt_usr_log.Text, txt_pass_log.Text);
            if (ac == null)
            {
                lbl_result.Text = "Authentication Failed!!Try again or create new account!!";
                txt_pass_log.Clear();
                txt_usr_log.Clear();
                txt_usr_log.Focus();
                return;
            }


            lbl_result.Text = "Authentication Succesfull!!";
            new Captcha().Show();
            this.Hide();

        }

        private void chk_box_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_box_show.Checked)
            {
                txt_pass_log.PasswordChar = '\0';
            }
            else
            {
                txt_pass_log.PasswordChar = '*';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_usr_log.Clear();
            txt_pass_log.Clear();
            txt_usr_log.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
