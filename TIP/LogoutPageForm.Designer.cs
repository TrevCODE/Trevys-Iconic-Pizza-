﻿namespace TIP
{
    partial class LogoutPageForm
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
            this.trademarkLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trademarkLabel
            // 
            this.trademarkLabel.AutoSize = true;
            this.trademarkLabel.Location = new System.Drawing.Point(199, 259);
            this.trademarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trademarkLabel.Name = "trademarkLabel";
            this.trademarkLabel.Size = new System.Drawing.Size(137, 13);
            this.trademarkLabel.TabIndex = 1;
            this.trademarkLabel.Text = "©2023 Trevy\'s Iconic Pizza";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.BackColor = System.Drawing.Color.Yellow;
            this.logoutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logoutLabel.Location = new System.Drawing.Point(27, 51);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(477, 31);
            this.logoutLabel.TabIndex = 2;
            this.logoutLabel.Text = "Thank you for ordering Trevy\'s Iconic Pizza!";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Yellow;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.returnButton.Location = new System.Drawing.Point(165, 138);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(196, 41);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return to home page";
            this.returnButton.UseVisualStyleBackColor = false;
            // 
            // LogoutPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(68)))));
            this.BackgroundImage = global::TIP.Properties.Resources.Pizza;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.trademarkLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogoutPageForm";
            this.Text = "Logout Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trademarkLabel;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Button returnButton;
    }
}