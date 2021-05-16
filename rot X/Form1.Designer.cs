
namespace rot_X
{
    partial class Form1
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
            this.Enkripto = new System.Windows.Forms.Button();
            this.plaintext = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dekripto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptertext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enkripto
            // 
            this.Enkripto.Location = new System.Drawing.Point(12, 152);
            this.Enkripto.Margin = new System.Windows.Forms.Padding(2);
            this.Enkripto.Name = "Enkripto";
            this.Enkripto.Size = new System.Drawing.Size(90, 27);
            this.Enkripto.TabIndex = 0;
            this.Enkripto.Text = "Enkripto";
            this.Enkripto.UseVisualStyleBackColor = true;
            this.Enkripto.Click += new System.EventHandler(this.button1_Click);
            // 
            // plaintext
            // 
            this.plaintext.Location = new System.Drawing.Point(12, 70);
            this.plaintext.Margin = new System.Windows.Forms.Padding(2);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(145, 27);
            this.plaintext.TabIndex = 1;
            this.plaintext.TextChanged += new System.EventHandler(this.plaintext_TextChanged);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(383, 70);
            this.key.Margin = new System.Windows.Forms.Padding(2);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(145, 27);
            this.key.TabIndex = 2;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ju lutem jepni tekstin per enkriptim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ju lutem jepni qelesin per enkriptim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ciphertext
            // 
            this.ciphertext.Location = new System.Drawing.Point(12, 241);
            this.ciphertext.Margin = new System.Windows.Forms.Padding(2);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(145, 27);
            this.ciphertext.TabIndex = 5;
            this.ciphertext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teksti i enkriptuar";
            // 
            // Dekripto
            // 
            this.Dekripto.Location = new System.Drawing.Point(383, 152);
            this.Dekripto.Margin = new System.Windows.Forms.Padding(2);
            this.Dekripto.Name = "Dekripto";
            this.Dekripto.Size = new System.Drawing.Size(90, 27);
            this.Dekripto.TabIndex = 7;
            this.Dekripto.Text = "Dekripto";
            this.Dekripto.UseVisualStyleBackColor = true;
            this.Dekripto.Click += new System.EventHandler(this.Dekripto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teksti i dekriptuar";
            // 
            // decryptertext
            // 
            this.decryptertext.Location = new System.Drawing.Point(383, 241);
            this.decryptertext.Margin = new System.Windows.Forms.Padding(2);
            this.decryptertext.Name = "decryptertext";
            this.decryptertext.Size = new System.Drawing.Size(150, 27);
            this.decryptertext.TabIndex = 9;
            this.decryptertext.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 360);
            this.Controls.Add(this.decryptertext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dekripto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ciphertext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.plaintext);
            this.Controls.Add(this.Enkripto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enkripto;
        private System.Windows.Forms.TextBox plaintext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ciphertext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dekripto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptertext;
        private System.Windows.Forms.TextBox key;
    }
}

