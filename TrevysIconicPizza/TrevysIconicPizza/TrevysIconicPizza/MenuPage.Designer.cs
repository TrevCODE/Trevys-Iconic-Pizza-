namespace TrevysIconicPizza
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
            this.pizzaButton = new System.Windows.Forms.Button();
            this.drinkButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pizzaButton
            // 
            this.pizzaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.pizzaButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaButton.ForeColor = System.Drawing.Color.White;
            this.pizzaButton.Location = new System.Drawing.Point(79, 298);
            this.pizzaButton.Name = "pizzaButton";
            this.pizzaButton.Size = new System.Drawing.Size(277, 106);
            this.pizzaButton.TabIndex = 0;
            this.pizzaButton.Text = "PIZZA";
            this.pizzaButton.UseVisualStyleBackColor = false;
            // 
            // drinkButton
            // 
            this.drinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(37)))));
            this.drinkButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkButton.ForeColor = System.Drawing.Color.White;
            this.drinkButton.Location = new System.Drawing.Point(394, 298);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(277, 106);
            this.drinkButton.TabIndex = 1;
            this.drinkButton.Text = "DRINKS";
            this.drinkButton.UseVisualStyleBackColor = false;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditLabel.Location = new System.Drawing.Point(292, 470);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(167, 16);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.Text = "© 2023 Trevy\'s Iconic Pizza";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(751, 495);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.drinkButton);
            this.Controls.Add(this.pizzaButton);
            this.Name = "MenuPage";
            this.Text = "MenuPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pizzaButton;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Label creditLabel;
    }
}