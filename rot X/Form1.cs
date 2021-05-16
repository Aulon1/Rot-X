using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rot_X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            string x = key.Text;
            int numVal = Int32.Parse(key.Text);
            string message = plaintext.Text;
            ciphertext.Text = rotX.Enkrypt(message, numVal);
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            sender = sender.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
      

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void plaintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dekripto_Click(object sender, EventArgs e)
        {
            string x = key.Text;
            int numVal = Int32.Parse(key.Text);
            string message = ciphertext.Text;
            decryptertext.Text = rotX.Dekrypt(message, numVal);

        }

    }
}


public class rotX
        {
            public static string Enkrypt(string plaintext, int key)
            {
                char[] array = plaintext.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];

                    if (number >= 'a' && number <= 'z')
                    {
                        if (number + (key % 26) > 122)
                        {

                            number = 96 + (number + (key % 26) - 122);

                        }
                        else
                        {
                            number += (key % 26);
                        }
                    }
                    else if (number >= 'A' && number <= 'Z')
                    {
                        if (number + (key % 26) > 90)
                        {
                            number = 64 + (number + (key % 26) - 90);
                        }
                        else
                        {
                            number += (key % 26);
                        }
                    }
                    array[i] = (char)number;
                }
                return new string(array);
            }

            public static string Dekrypt(string ciphertext, int key)
            {
                char[] array = ciphertext.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    int number = (int)array[i];

                    if (number >= 'a' && number <= 'z')
                    {
                        if (number - (key % 26) < 97)
                        {
                            number = 123 - (97 - (number - (key % 26)));
                        }
                        else
                        {
                            number = number - (key % 26);
                        }
                    }
                    else if (number >= 'A' && number <= 'Z')
                    {
                        if (number - (key % 26) < 65)
                        {
                            number = 65 - (91 - (number - (key % 26)));
                        }
                        else
                        {
                            number -= (key % 26);
                        }
                    }
                    array[i] = (char)number;
                }
                return new string(array);
            }

        }
