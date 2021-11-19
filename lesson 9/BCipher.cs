using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class BCipher:ICipher
    {
        static string letters = "абвгдежзийклмнопрстуфхцчшщъыьэюяАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        char[] alphabet = letters.ToCharArray();
        public void Encode(string word_code) 
        {
            try
            {
                char[] massive_word = word_code.ToCharArray();
                for (int i = 0; i < massive_word.Length; i++)
                {
                    if (massive_word[i].Equals(' ')) { Console.Write(" "); }
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (massive_word[i].Equals(alphabet[k]))
                        {
                            int k_new = 31 - k;
                            Console.Write(alphabet[k_new]);

                        }

                    }
                }

            }
            catch
            {
                Console.WriteLine("Вы ввели неподходящий символ");
            }
        }

        public void Decode(string decode_name) 
        {
            Encode(decode_name);
        }
        
            
        
    }
}
