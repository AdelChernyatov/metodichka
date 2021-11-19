using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Car_race : IGames
    {
        public void PLay_games(string[] array)
        {
            Console.WriteLine("Команда выставляет гонщиков ,и те соревнуются на баллидах Formula 1");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Победителем гонок стала команда " + winner);
        }
    }
}
