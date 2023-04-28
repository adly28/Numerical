namespace NumericalPRG
{
    partial class False_Position
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.txtroot = new System.Windows.Forms.TextBox();
            this.data1 = new System.Windows.Forms.DataGridView();
            this.clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txteps = new System.Windows.Forms.TextBox();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxu = new System.Windows.Forms.TextBox();
            this.txtxl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Root";
            // 
            // txtroot
            // 
            this.txtroot.Location = new System.Drawing.Point(105, 81);
            this.txtroot.Name = "txtroot";
            this.txtroot.Size = new System.Drawing.Size(100, 23);
            this.txtroot.TabIndex = 27;
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Location = new System.Drawing.Point(2, 169);
            this.data1.Name = "data1";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.data1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data1.RowTemplate.Height = 25;
            this.data1.Size = new System.Drawing.Size(797, 232);
            this.data1.TabIndex = 26;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(706, 132);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 31);
            this.clear.TabIndex = 25;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(2, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txteps
            // 
            this.txteps.Location = new System.Drawing.Point(593, 81);
            this.txteps.Name = "txteps";
            this.txteps.Size = new System.Drawing.Size(100, 23);
            this.txteps.TabIndex = 23;
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(105, 25);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(176, 23);
            this.txtEquation.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "F(X)";
            // 
            // txtxu
            // 
            this.txtxu.Location = new System.Drawing.Point(593, 42);
            this.txtxu.Name = "txtxu";
            this.txtxu.Size = new System.Drawing.Size(100, 23);
            this.txtxu.TabIndex = 20;
            // 
            // txtxl
            // 
            this.txtxl.Location = new System.Drawing.Point(593, 6);
            this.txtxl.Name = "txtxl";
            this.txtxl.Size = new System.Drawing.Size(100, 23);
            this.txtxl.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(507, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "XL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(505, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "XU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(507, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Eps";
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calc.Location = new System.Drawing.Point(593, 132);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(91, 31);
            this.calc.TabIndex = 15;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // False_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtroot);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txteps);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtxu);
            this.Controls.Add(this.txtxl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc);
            this.Name = "False_Position";
            this.Text = "False_Position";
            this.Load += new System.EventHandler(this.False_Position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private TextBox txtroot;
        private DataGridView data1;
        private Button clear;
        private Button button2;
        private TextBox txteps;
        private TextBox txtEquation;
        private Label label4;
        private TextBox txtxu;
        private TextBox txtxl;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button calc;
    }
}