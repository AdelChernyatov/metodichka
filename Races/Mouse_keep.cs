using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Mouse_keep : IGames
    {
        public void PLay_games(string[] array)
        {
            Console.WriteLine("Участникам игры предстоит почуствовать себя мышатами, в так называемой <клетке>"+"\n"+"Они будут бегать по лабиринту и искать <сыр>,чья команда соберет наибольшее кол-во - побуждают");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Команда "+winner+" собрала наибольшее  кол-во сыра");
        }
    }
}
