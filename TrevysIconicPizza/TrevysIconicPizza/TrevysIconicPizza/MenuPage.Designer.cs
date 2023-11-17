﻿namespace TrevysIconicPizza
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.pizzaButton = new System.Windows.Forms.Button();
            this.drinkButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.questionMarkPicture = new System.Windows.Forms.PictureBox();
            this.cartPicture = new System.Windows.Forms.PictureBox();
            this.accountPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionMarkPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaButton
            // 
            this.pizzaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.pizzaButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaButton.ForeColor = System.Drawing.Color.White;
            this.pizzaButton.Location = new System.Drawing.Point(59, 269);
            this.pizzaButton.Margin = new System.Windows.Forms.Padding(2);
            this.pizzaButton.Name = "pizzaButton";
            this.pizzaButton.Size = new System.Drawing.Size(208, 86);
            this.pizzaButton.TabIndex = 0;
            this.pizzaButton.Text = "PIZZA";
            this.pizzaButton.UseVisualStyleBackColor = false;
            this.pizzaButton.Click += new System.EventHandler(this.pizzaButton_Click);
            // 
            // drinkButton
            // 
            this.drinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.drinkButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkButton.ForeColor = System.Drawing.Color.White;
            this.drinkButton.Location = new System.Drawing.Point(296, 269);
            this.drinkButton.Margin = new System.Windows.Forms.Padding(2);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(208, 86);
            this.drinkButton.TabIndex = 1;
            this.drinkButton.Text = "DRINKS";
            this.drinkButton.UseVisualStyleBackColor = false;
            this.drinkButton.Click += new System.EventHandler(this.drinkButton_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditLabel.Location = new System.Drawing.Point(219, 382);
            this.creditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(140, 13);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.Text = "© 2023 Trevy\'s Iconic Pizza";
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(166, 20);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(230, 229);
            this.logoPicture.TabIndex = 3;
            this.logoPicture.TabStop = false;
            // 
            // questionMarkPicture
            // 
            this.questionMarkPicture.Image = ((System.Drawing.Image)(resources.GetObject("questionMarkPicture.Image")));
            this.questionMarkPicture.Location = new System.Drawing.Point(480, 7);
            this.questionMarkPicture.Name = "questionMarkPicture";
            this.questionMarkPicture.Size = new System.Drawing.Size(24, 23);
            this.questionMarkPicture.TabIndex = 4;
            this.questionMarkPicture.TabStop = false;
            // 
            // cartPicture
            // 
            this.cartPicture.Image = ((System.Drawing.Image)(resources.GetObject("cartPicture.Image")));
            this.cartPicture.Location = new System.Drawing.Point(518, 7);
            this.cartPicture.Name = "cartPicture";
            this.cartPicture.Size = new System.Drawing.Size(24, 23);
            this.cartPicture.TabIndex = 5;
            this.cartPicture.TabStop = false;
            // 
            // accountPictureBox
            // 
            this.accountPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("accountPictureBox.Image")));
            this.accountPictureBox.Location = new System.Drawing.Point(13, 7);
            this.accountPictureBox.Name = "accountPictureBox";
            this.accountPictureBox.Size = new System.Drawing.Size(24, 23);
            this.accountPictureBox.TabIndex = 6;
            this.accountPictureBox.TabStop = false;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(563, 402);
            this.Controls.Add(this.accountPictureBox);
            this.Controls.Add(this.cartPicture);
            this.Controls.Add(this.questionMarkPicture);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.drinkButton);
            this.Controls.Add(this.pizzaButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPage";
            this.Text = "MenuPage";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionMarkPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pizzaButton;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.PictureBox questionMarkPicture;
        private System.Windows.Forms.PictureBox cartPicture;
        private System.Windows.Forms.PictureBox accountPictureBox;
    }
}