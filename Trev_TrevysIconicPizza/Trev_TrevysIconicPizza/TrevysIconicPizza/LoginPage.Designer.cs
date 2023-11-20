using System.Windows.Forms;

namespace TrevysIconicPizza
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.UserNameTextBox.Location = new System.Drawing.Point(351, 177);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(268, 26);
========
            this.UserNameTextBox.Location = new System.Drawing.Point(234, 115);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(180, 20);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.UserNameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.PasswordTextBox.Location = new System.Drawing.Point(351, 291);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(268, 26);
========
            this.PasswordTextBox.Location = new System.Drawing.Point(234, 189);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(180, 20);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.LoginButton.Location = new System.Drawing.Point(550, 360);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(218, 77);
========
            this.LoginButton.Location = new System.Drawing.Point(367, 234);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(145, 50);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeLabel.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Image = ((System.Drawing.Image)(resources.GetObject("WelcomeLabel.Image")));
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.WelcomeLabel.Location = new System.Drawing.Point(237, 58);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(384, 54);
========
            this.WelcomeLabel.Location = new System.Drawing.Point(158, 38);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(256, 35);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome Back!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameLabel
            // 
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(153, 178);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(150, 35);
========
            this.UserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.UserNameLabel.Location = new System.Drawing.Point(102, 116);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(82, 19);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(153, 292);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(150, 35);
========
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.PasswordLabel.Location = new System.Drawing.Point(102, 190);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 19);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(630, 294);
            this.ShowPasswordCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(168, 24);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
========
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(420, 191);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(115, 17);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = false;
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.copyrightLabel.Location = new System.Drawing.Point(322, 569);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(242, 35);
========
            this.copyrightLabel.Location = new System.Drawing.Point(215, 370);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(161, 23);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.copyrightLabel.TabIndex = 7;
            this.copyrightLabel.Text = "© 2023 Trevy\'s Iconic Pizza";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.LoginButton);
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.loginPanel.Location = new System.Drawing.Point(35, 27);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(779, 539);
========
            this.loginPanel.Location = new System.Drawing.Point(23, 18);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(520, 351);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.loginPanel.TabIndex = 8;
            // 
            // LoginPage
            // 
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 618);
========
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(563, 402);
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.loginPanel);
            this.DoubleBuffered = true;
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
========
            this.MaximumSize = new System.Drawing.Size(579, 441);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/LoginPage.Designer.cs
            this.loginPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label copyrightLabel;
        private Panel loginPanel;
    }
}