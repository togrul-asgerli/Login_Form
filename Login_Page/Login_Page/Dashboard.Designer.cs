namespace Login_Page
{
    partial class Dashboard
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
            this.btn_out = new System.Windows.Forms.Button();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_out.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_out.Location = new System.Drawing.Point(511, 1);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(110, 34);
            this.btn_out.TabIndex = 0;
            this.btn_out.Text = "Log Out";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.Location = new System.Drawing.Point(99, 114);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(345, 39);
            this.lbl_mes.TabIndex = 1;
            this.lbl_mes.Text = "Welcome to Session";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Page.Properties.Resources.nature;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.btn_out);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label lbl_mes;
    }
}