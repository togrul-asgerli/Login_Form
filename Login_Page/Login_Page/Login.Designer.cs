namespace Login_Page
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.chk_box_show = new System.Windows.Forms.CheckBox();
            this.txt_pass_log = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_usr_log = new System.Windows.Forms.TextBox();
            this.lbl_usr = new System.Windows.Forms.Label();
            this.start_lbl = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(129, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Create Account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dont Have an Account";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_clear.Location = new System.Drawing.Point(94, 405);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(216, 38);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_log.FlatAppearance.BorderSize = 0;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.ForeColor = System.Drawing.Color.White;
            this.btn_log.Location = new System.Drawing.Point(94, 353);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(216, 38);
            this.btn_log.TabIndex = 20;
            this.btn_log.Text = "Log In";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // chk_box_show
            // 
            this.chk_box_show.AutoSize = true;
            this.chk_box_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_box_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_box_show.Location = new System.Drawing.Point(213, 311);
            this.chk_box_show.Name = "chk_box_show";
            this.chk_box_show.Size = new System.Drawing.Size(151, 27);
            this.chk_box_show.TabIndex = 19;
            this.chk_box_show.Text = "Show Password";
            this.chk_box_show.UseVisualStyleBackColor = true;
            this.chk_box_show.CheckedChanged += new System.EventHandler(this.chk_box_show_CheckedChanged);
            // 
            // txt_pass_log
            // 
            this.txt_pass_log.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_pass_log.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_log.Location = new System.Drawing.Point(94, 276);
            this.txt_pass_log.Multiline = true;
            this.txt_pass_log.Name = "txt_pass_log";
            this.txt_pass_log.PasswordChar = '*';
            this.txt_pass_log.Size = new System.Drawing.Size(216, 29);
            this.txt_pass_log.TabIndex = 16;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(90, 250);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(84, 23);
            this.lbl_pass.TabIndex = 15;
            this.lbl_pass.Text = "Password";
            // 
            // txt_usr_log
            // 
            this.txt_usr_log.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_usr_log.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usr_log.Location = new System.Drawing.Point(94, 200);
            this.txt_usr_log.Multiline = true;
            this.txt_usr_log.Name = "txt_usr_log";
            this.txt_usr_log.Size = new System.Drawing.Size(216, 29);
            this.txt_usr_log.TabIndex = 14;
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Location = new System.Drawing.Point(90, 174);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(89, 23);
            this.lbl_usr.TabIndex = 13;
            this.lbl_usr.Text = "Username";
            // 
            // start_lbl
            // 
            this.start_lbl.AutoSize = true;
            this.start_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbl.Location = new System.Drawing.Point(86, 102);
            this.start_lbl.Name = "start_lbl";
            this.start_lbl.Size = new System.Drawing.Size(209, 44);
            this.start_lbl.TabIndex = 12;
            this.start_lbl.Text = "Get Started";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(21, 38);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 23);
            this.lbl_result.TabIndex = 24;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(365, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(41, 27);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 544);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.chk_box_show);
            this.Controls.Add(this.txt_pass_log);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_usr_log);
            this.Controls.Add(this.lbl_usr);
            this.Controls.Add(this.start_lbl);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.CheckBox chk_box_show;
        private System.Windows.Forms.TextBox txt_pass_log;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_usr_log;
        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.Label start_lbl;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_close;
    }
}