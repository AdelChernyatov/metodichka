using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Fishing:IGames
    {       
        public void PLay_games(string[] array)
        {
            Console.WriteLine("На Черном море вблизи Геленджика следующее испытание");
            Console.WriteLine("Наверняка все вы видели с экранов телевизора такой спорт,как скоростная рыбалка."+"\n"+"Участникам предстоит выделить победителя путем итогового подсчета рыбы по истечении времени.");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Командой,которая поймала наибольшее кол-во рыб " +winner);
        }
    }
}
