using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Acipher:ICipher
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
                            int k_new = k + 1;
                            if (k_new == 32) { Console.Write("a"); }
                            if (k_new == 64) { Console.Write("А"); }
                            else { Console.Write(alphabet[k_new]); }

                        }

                    }
                }

            }
            catch 
            {
                Console.WriteLine("Вы ввели неподходящий символ");
            }
            
        }
        public void Decode(string word_decode) 
        {
            try
            {
                char[] massive_word = word_decode.ToCharArray();
                for (int i = 0; i < massive_word.Length; i++)
                {
                    if (massive_word[i].Equals(' ')) { Console.Write(" "); }
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (massive_word[i].Equals(alphabet[k]))
                        {
                            int k_new = k - 1;
                            if (k_new == -1) { Console.Write("я"); continue; }
                            if (k_new == 32) { Console.Write("Я"); }
                            else { Console.Write(alphabet[k_new]); }
                        }
                    }
                }
            }
            catch 
            {
                Console.WriteLine("Вы ввели неподходящий символ");
            }
            
        }
    }
}
