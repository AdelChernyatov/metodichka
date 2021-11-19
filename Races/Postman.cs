using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Postman : IGames
    {
        public void PLay_games(string[] array)
        {
            Console.WriteLine("Игра в почтальона");
            Console.WriteLine("Участникам команд нужно будет донести наибольшее кол-во писем до заранее известных адресов,"+"\n"+"чьи участники доставят наибольшее кол-во писем - выйграют ");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Команда победителей" + winner);
        }
    }
}
