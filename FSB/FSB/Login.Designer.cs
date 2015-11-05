namespace FSB
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterUser = new System.Windows.Forms.TextBox();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.llPassVergessen = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.tbLoginUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.tbRegisterMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRegisterPasswordCheck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSavePassword = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(6, 126);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(283, 33);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrieren";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // tbRegisterUser
            // 
            this.tbRegisterUser.Location = new System.Drawing.Point(144, 16);
            this.tbRegisterUser.Name = "tbRegisterUser";
            this.tbRegisterUser.Size = new System.Drawing.Size(129, 20);
            this.tbRegisterUser.TabIndex = 4;
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.Location = new System.Drawing.Point(144, 68);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.PasswordChar = '*';
            this.tbRegisterPassword.Size = new System.Drawing.Size(129, 20);
            this.tbRegisterPassword.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegister);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 193);
            this.tabControl1.TabIndex = 6;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.cbSavePassword);
            this.tabLogin.Controls.Add(this.llPassVergessen);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.tbLoginPassword);
            this.tabLogin.Controls.Add(this.tbLoginUser);
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.label4);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(295, 167);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // llPassVergessen
            // 
            this.llPassVergessen.AutoSize = true;
            this.llPassVergessen.Location = new System.Drawing.Point(177, 107);
            this.llPassVergessen.Name = "llPassVergessen";
            this.llPassVergessen.Size = new System.Drawing.Size(108, 13);
            this.llPassVergessen.TabIndex = 11;
            this.llPassVergessen.TabStop = true;
            this.llPassVergessen.Text = "Passwort vergessen?";
            this.llPassVergessen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPassvergessen_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(6, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(283, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(98, 64);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(172, 20);
            this.tbLoginPassword.TabIndex = 10;
            // 
            // tbLoginUser
            // 
            this.tbLoginUser.Location = new System.Drawing.Point(98, 27);
            this.tbLoginUser.Name = "tbLoginUser";
            this.tbLoginUser.Size = new System.Drawing.Size(172, 20);
            this.tbLoginUser.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Passwort";
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.tbRegisterMail);
            this.tabRegister.Controls.Add(this.label6);
            this.tabRegister.Controls.Add(this.tbRegisterPasswordCheck);
            this.tabRegister.Controls.Add(this.label5);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.tbRegisterPassword);
            this.tabRegister.Controls.Add(this.tbRegisterUser);
            this.tabRegister.Controls.Add(this.label1);
            this.tabRegister.Controls.Add(this.label2);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(295, 167);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Registrieren";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // tbRegisterMail
            // 
            this.tbRegisterMail.Location = new System.Drawing.Point(144, 42);
            this.tbRegisterMail.Name = "tbRegisterMail";
            this.tbRegisterMail.Size = new System.Drawing.Size(129, 20);
            this.tbRegisterMail.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-Mailadresse";
            // 
            // tbRegisterPasswordCheck
            // 
            this.tbRegisterPasswordCheck.Location = new System.Drawing.Point(144, 94);
            this.tbRegisterPasswordCheck.Name = "tbRegisterPasswordCheck";
            this.tbRegisterPasswordCheck.PasswordChar = '*';
            this.tbRegisterPasswordCheck.Size = new System.Drawing.Size(129, 20);
            this.tbRegisterPasswordCheck.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Passwort bestätigen";
            // 
            // cbSavePassword
            // 
            this.cbSavePassword.AutoSize = true;
            this.cbSavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSavePassword.Location = new System.Drawing.Point(18, 107);
            this.cbSavePassword.Name = "cbSavePassword";
            this.cbSavePassword.Size = new System.Drawing.Size(115, 17);
            this.cbSavePassword.TabIndex = 12;
            this.cbSavePassword.Text = "Eingabe Speichern";
            this.cbSavePassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 192);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Freundebuch - 1.0";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterUser;
        private System.Windows.Forms.TextBox tbRegisterPassword;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRegisterPasswordCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llPassVergessen;
        private System.Windows.Forms.TextBox tbRegisterMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSavePassword;
    }
}

