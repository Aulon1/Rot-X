
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
            this.Enkripto.Location = new System.Drawing.Point(15, 190);
            this.Enkripto.Name = "Enkripto";
            this.Enkripto.Size = new System.Drawing.Size(112, 34);
            this.Enkripto.TabIndex = 0;
            this.Enkripto.Text = "Enkripto";
            this.Enkripto.UseVisualStyleBackColor = true;
            this.Enkripto.Click += new System.EventHandler(this.button1_Click);
            // 
            // plaintext
            // 
            this.plaintext.Location = new System.Drawing.Point(15, 87);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(180, 31);
            this.plaintext.TabIndex = 1;
            this.plaintext.TextChanged += new System.EventHandler(this.plaintext_TextChanged);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(479, 87);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(180, 31);
            this.key.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ju lutem jepni tekstin per enkriptim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ju lutem jepni qelesin per enkriptim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ciphertext
            // 
            this.ciphertext.Location = new System.Drawing.Point(15, 301);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(180, 31);
            this.ciphertext.TabIndex = 5;
            this.ciphertext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teksti i enkriptuar";
            // 
            // Dekripto
            // 
            this.Dekripto.Location = new System.Drawing.Point(479, 190);
            this.Dekripto.Name = "Dekripto";
            this.Dekripto.Size = new System.Drawing.Size(112, 34);
            this.Dekripto.TabIndex = 7;
            this.Dekripto.Text = "Dekripto";
            this.Dekripto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teksti i dekriptuar";
            // 
            // decryptertext
            // 
            this.decryptertext.Location = new System.Drawing.Point(479, 301);
            this.decryptertext.Name = "decryptertext";
            this.decryptertext.Size = new System.Drawing.Size(180, 31);
            this.decryptertext.TabIndex = 9;
            this.decryptertext.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

