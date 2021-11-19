using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Beach:IGames
    {
        public void PLay_games(string [] array)
        {
            Console.WriteLine("Под названием <Пляж> подразумевается пляжный футбол");
            Console.WriteLine("Место проведения - солнечная Бразилия");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Сильнейшими футболистами оказались представители команды "+winner);
        }
    }
}
