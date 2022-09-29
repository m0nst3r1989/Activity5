namespace Activity5
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfirstword = new System.Windows.Forms.TextBox();
            this.txtlastword = new System.Windows.Forms.TextBox();
            this.txtlongest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mostVowel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select File :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(308, 89);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(409, 28);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select Here";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtdisplay
            // 
            this.txtdisplay.Location = new System.Drawing.Point(308, 151);
            this.txtdisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(687, 345);
            this.txtdisplay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lower Case :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 577);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 629);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Word";
            // 
            // txtfirstword
            // 
            this.txtfirstword.Location = new System.Drawing.Point(308, 577);
            this.txtfirstword.Margin = new System.Windows.Forms.Padding(4);
            this.txtfirstword.Name = "txtfirstword";
            this.txtfirstword.Size = new System.Drawing.Size(445, 22);
            this.txtfirstword.TabIndex = 6;
            // 
            // txtlastword
            // 
            this.txtlastword.Location = new System.Drawing.Point(308, 629);
            this.txtlastword.Margin = new System.Windows.Forms.Padding(4);
            this.txtlastword.Name = "txtlastword";
            this.txtlastword.Size = new System.Drawing.Size(445, 22);
            this.txtlastword.TabIndex = 7;
            // 
            // txtlongest
            // 
            this.txtlongest.Location = new System.Drawing.Point(308, 690);
            this.txtlongest.Margin = new System.Windows.Forms.Padding(4);
            this.txtlongest.Name = "txtlongest";
            this.txtlongest.Size = new System.Drawing.Size(445, 22);
            this.txtlongest.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 694);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Longest Word";
            // 
            // mostVowel
            // 
            this.mostVowel.Location = new System.Drawing.Point(308, 752);
            this.mostVowel.Margin = new System.Windows.Forms.Padding(4);
            this.mostVowel.Name = "mostVowel";
            this.mostVowel.Size = new System.Drawing.Size(445, 22);
            this.mostVowel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 756);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Longest Vowel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 849);
            this.Controls.Add(this.mostVowel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtlongest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlastword);
            this.Controls.Add(this.txtfirstword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfirstword;
        private System.Windows.Forms.TextBox txtlastword;
        private System.Windows.Forms.TextBox txtlongest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mostVowel;
        private System.Windows.Forms.Label label6;
    }
}

