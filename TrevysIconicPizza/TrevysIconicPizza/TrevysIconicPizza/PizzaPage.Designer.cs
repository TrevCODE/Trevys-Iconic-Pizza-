namespace TrevysIconicPizza
{
    partial class PizzaPage
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
            this.pizzaMenuLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaMenuLabel
            // 
            this.pizzaMenuLabel.AutoSize = true;
            this.pizzaMenuLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaMenuLabel.ForeColor = System.Drawing.Color.White;
            this.pizzaMenuLabel.Location = new System.Drawing.Point(417, 25);
            this.pizzaMenuLabel.Name = "pizzaMenuLabel";
            this.pizzaMenuLabel.Size = new System.Drawing.Size(260, 46);
            this.pizzaMenuLabel.TabIndex = 0;
            this.pizzaMenuLabel.Text = "PIZZA MENU";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(11, 88);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Size = new System.Drawing.Size(1082, 565);
            this.splitContainer1.SplitterDistance = 536;
            this.splitContainer1.TabIndex = 2;
            // 
            // PizzaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1104, 665);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pizzaMenuLabel);
            this.Name = "PizzaPage";
            this.Text = "PizzaPage";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaMenuLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}