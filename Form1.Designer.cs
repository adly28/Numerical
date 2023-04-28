namespace NumericalPRG
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Bisection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bisection
            // 
            this.Bisection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bisection.Location = new System.Drawing.Point(12, 25);
            this.Bisection.Name = "Bisection";
            this.Bisection.Size = new System.Drawing.Size(122, 64);
            this.Bisection.TabIndex = 0;
            this.Bisection.Text = "Bisection";
            this.Bisection.UseVisualStyleBackColor = true;
            this.Bisection.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "False Position";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Fixed Point";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(177, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 62);
            this.button4.TabIndex = 4;
            this.button4.Text = "Scant ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(177, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "Newton";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(177, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 62);
            this.button6.TabIndex = 6;
            this.button6.Text = "Gauss";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bisection);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Bisection;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}