namespace Login_Page
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_lbl = new System.Windows.Forms.Label();
            this.lbl_usr = new System.Windows.Forms.Label();
            this.txt_usr = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_conf = new System.Windows.Forms.TextBox();
            this.lbl_conf = new System.Windows.Forms.Label();
            this.chk_box_show = new System.Windows.Forms.CheckBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mesg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(71, 20);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(209, 44);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Get Started";
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Location = new System.Drawing.Point(75, 92);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(87, 23);
            this.lbl_usr.TabIndex = 1;
            this.lbl_usr.Text = "Username";
            // 
            // txt_usr
            // 
            this.txt_usr.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_usr.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usr.Location = new System.Drawing.Point(79, 118);
            this.txt_usr.Multiline = true;
            this.txt_usr.Name = "txt_usr";
            this.txt_usr.Size = new System.Drawing.Size(216, 29);
            this.txt_usr.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_pass.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(79, 194);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(216, 29);
            this.txt_pass.TabIndex = 4;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(75, 168);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(80, 23);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_conf
            // 
            this.txt_conf.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_conf.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conf.Location = new System.Drawing.Point(79, 268);
            this.txt_conf.Multiline = true;
            this.txt_conf.Name = "txt_conf";
            this.txt_conf.PasswordChar = '*';
            this.txt_conf.Size = new System.Drawing.Size(216, 29);
            this.txt_conf.TabIndex = 6;
            // 
            // lbl_conf
            // 
            this.lbl_conf.AutoSize = true;
            this.lbl_conf.Location = new System.Drawing.Point(75, 242);
            this.lbl_conf.Name = "lbl_conf";
            this.lbl_conf.Size = new System.Drawing.Size(146, 23);
            this.lbl_conf.TabIndex = 5;
            this.lbl_conf.Text = "Confirm Password";
            // 
            // chk_box_show
            // 
            this.chk_box_show.AutoSize = true;
            this.chk_box_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_box_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_box_show.Location = new System.Drawing.Point(212, 312);
            this.chk_box_show.Name = "chk_box_show";
            this.chk_box_show.Size = new System.Drawing.Size(144, 27);
            this.chk_box_show.TabIndex = 7;
            this.chk_box_show.Text = "Show Password";
            this.chk_box_show.UseVisualStyleBackColor = true;
            this.chk_box_show.CheckedChanged += new System.EventHandler(this.chk_box_show_CheckedChanged);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reg.FlatAppearance.BorderSize = 0;
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg.ForeColor = System.Drawing.Color.White;
            this.btn_reg.Location = new System.Drawing.Point(79, 356);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(216, 35);
            this.btn_reg.TabIndex = 8;
            this.btn_reg.Text = "REGISTER";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_clear.Location = new System.Drawing.Point(79, 408);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(216, 35);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Already Have an Account";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(125, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Back to Log In";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_mesg
            // 
            this.lbl_mesg.AutoSize = true;
            this.lbl_mesg.Location = new System.Drawing.Point(48, 494);
            this.lbl_mesg.Name = "lbl_mesg";
            this.lbl_mesg.Size = new System.Drawing.Size(0, 23);
            this.lbl_mesg.TabIndex = 12;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 544);
            this.Controls.Add(this.lbl_mesg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.chk_box_show);
            this.Controls.Add(this.txt_conf);
            this.Controls.Add(this.lbl_conf);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_usr);
            this.Controls.Add(this.lbl_usr);
            this.Controls.Add(this.name_lbl);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.TextBox txt_usr;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_conf;
        private System.Windows.Forms.Label lbl_conf;
        private System.Windows.Forms.CheckBox chk_box_show;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mesg;
    }
}

