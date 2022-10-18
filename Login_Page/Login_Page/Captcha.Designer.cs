namespace Login_Page
{
    partial class Captcha
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
            this.lbl_cap = new System.Windows.Forms.Label();
            this.txt_check = new System.Windows.Forms.TextBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cap
            // 
            this.lbl_cap.AutoSize = true;
            this.lbl_cap.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cap.Location = new System.Drawing.Point(221, 163);
            this.lbl_cap.Name = "lbl_cap";
            this.lbl_cap.Size = new System.Drawing.Size(0, 23);
            this.lbl_cap.TabIndex = 0;
            // 
            // txt_check
            // 
            this.txt_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_check.Location = new System.Drawing.Point(192, 255);
            this.txt_check.Multiline = true;
            this.txt_check.Name = "txt_check";
            this.txt_check.Size = new System.Drawing.Size(236, 50);
            this.txt_check.TabIndex = 1;
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.Location = new System.Drawing.Point(197, 227);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(231, 25);
            this.lbl_text.TabIndex = 2;
            this.lbl_text.Text = "Type what you are see";
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(239, 311);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(128, 53);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.Location = new System.Drawing.Point(21, 72);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(0, 38);
            this.lbl_mes.TabIndex = 4;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Cyan;
            this.btn_back.Location = new System.Drawing.Point(645, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 32);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Page.Properties.Resources.Captcha;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.txt_check);
            this.Controls.Add(this.lbl_cap);
            this.Name = "Captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            this.Load += new System.EventHandler(this.Captcha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cap;
        private System.Windows.Forms.TextBox txt_check;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Button btn_back;
    }
}