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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            bool rc = Db_Class.acc_exsist(txt_usr.Text);
            
            if (txt_usr.Text == "" && txt_pass.Text == "" && txt_conf.Text == "")
            {
                lbl_mesg.Text = "Username or password can't be blank.Sign Up failed!";
            }
            else if (txt_pass.Text == txt_conf.Text)
            {
                if(rc)
                {
                    lbl_mesg.Text = "Account already exsist!!";
                    return;
                }
                Account ac = Db_Class.account_register(txt_usr.Text, txt_pass.Text);
                lbl_mesg.Text = "Your account succesfully created";
                txt_usr.Text = "";
                txt_pass.Text = "";
                txt_conf.Text = "";
            }
            else
            {
                lbl_mesg.Text = "Passwords don't match.Please Re-enter";
                txt_pass.Text = "";
                txt_conf.Text = "";
                txt_pass.Focus();
            }

        }

        private void chk_box_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_box_show.Checked)
            {
                txt_pass.PasswordChar = '\0';
                txt_conf.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
                txt_conf.PasswordChar = '*';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_usr.Text = "";
            txt_pass.Text = "";
            txt_conf.Text = "";
            txt_usr.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
