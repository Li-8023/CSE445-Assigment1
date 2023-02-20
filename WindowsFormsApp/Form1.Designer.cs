namespace WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_vowel = new System.Windows.Forms.TextBox();
            this.textBox_upper = new System.Windows.Forms.TextBox();
            this.textBox_numWords = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vowel Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uppercase Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Words";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(261, 25);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(240, 26);
            this.textBox_input.TabIndex = 4;
            // 
            // textBox_vowel
            // 
            this.textBox_vowel.Location = new System.Drawing.Point(261, 93);
            this.textBox_vowel.Name = "textBox_vowel";
            this.textBox_vowel.Size = new System.Drawing.Size(240, 26);
            this.textBox_vowel.TabIndex = 5;
            // 
            // textBox_upper
            // 
            this.textBox_upper.Location = new System.Drawing.Point(261, 155);
            this.textBox_upper.Name = "textBox_upper";
            this.textBox_upper.Size = new System.Drawing.Size(240, 26);
            this.textBox_upper.TabIndex = 6;
            // 
            // textBox_numWords
            // 
            this.textBox_numWords.Location = new System.Drawing.Point(261, 232);
            this.textBox_numWords.Name = "textBox_numWords";
            this.textBox_numWords.Size = new System.Drawing.Size(240, 26);
            this.textBox_numWords.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_numWords);
            this.Controls.Add(this.textBox_upper);
            this.Controls.Add(this.textBox_vowel);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_vowel;
        private System.Windows.Forms.TextBox textBox_upper;
        private System.Windows.Forms.TextBox textBox_numWords;
        private System.Windows.Forms.Button button1;
    }
}

