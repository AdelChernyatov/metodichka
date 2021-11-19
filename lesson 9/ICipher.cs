using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    interface ICipher
    {
        void Encode(string word_code);
        void Decode(string word_decode);
    }
}
