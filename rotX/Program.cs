using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotX
{
    class Program
    {
        static void Main(string[] args)
        {
            string plaintext,key;
            Console.WriteLine("Shenoni plaintextin");
            plaintext = Console.ReadLine();
            Adresa:
            Console.WriteLine("Shenoni celesin");
            
            key = Console.ReadLine();
            int i = 0;
            bool result = int.TryParse(key, out i);
            if (!result) {
                goto Adresa;
            }



            string ciphertext = Enkrypt(plaintext, int.Parse(key));
            Console.WriteLine("Ciphertexti i fituar: " + ciphertext);

            string decryptedtext = Dekrypt(ciphertext, int.Parse(key));
            Console.WriteLine("Decrypted teksti i fituar: " + decryptedtext);

            Console.ReadKey();
        }

       
        public static string Enkrypt(string plaintext, int key)
        {
            char[] array = plaintext.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number + (key%26) > 122 )
                    {
                        
                       number = 96+(number+ (key % 26) - 122 );
                        
                    }
                    else
                    {
                        number += (key % 26);
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number+ (key % 26) > 90)
                    {
                        number =64+(number + (key % 26) - 90);
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
                        number = 123 - (97-(number- (key % 26)));
                    }
                    else
                    {
                        number =number- (key % 26);
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number - (key % 26) < 65)
                    {
                        number = 65 - (91-(number- (key % 26)));
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
}
