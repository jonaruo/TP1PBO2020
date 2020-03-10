namespace TP1PBO2020
{
    partial class Form1
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
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tx_username = new System.Windows.Forms.Label();
            this.tx_password = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(132, 107);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 22);
            this.tb_pass.TabIndex = 1;
            // 
            // tx_username
            // 
            this.tx_username.AutoSize = true;
            this.tx_username.Location = new System.Drawing.Point(26, 48);
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(73, 17);
            this.tx_username.TabIndex = 2;
            this.tx_username.Text = "Username";
            // 
            // tx_password
            // 
            this.tx_password.AutoSize = true;
            this.tx_password.Location = new System.Drawing.Point(26, 110);
            this.tx_password.Name = "tx_password";
            this.tx_password.Size = new System.Drawing.Size(69, 17);
            this.tx_password.TabIndex = 3;
            this.tx_password.Text = "Password";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(143, 165);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 27);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(132, 45);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 22);
            this.tb_user.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 309);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tx_password);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.tb_pass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label tx_username;
        private System.Windows.Forms.Label tx_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_user;
    }
}

