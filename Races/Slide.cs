using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Slide : IGames
    {
        public void PLay_games(string[] array)
        {
            Console.WriteLine("Игра проходит на горе Эверест");
            Console.WriteLine("Команда,наибольшее кол-во участников которых заберется на Эверест-выйграет");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Команда покорителей Эвереста "+winner);
        }
    }
}
