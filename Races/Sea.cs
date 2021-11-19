using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Sea : IGames
    {
        public void PLay_games(string[] array)
        {
            Console.WriteLine("Участникам предстоит отыскать сокровище в просторах Красного моря в Египте");
            Console.WriteLine("Чья команда соберет наибольшее кол-во сундуков - выйграют");
            Random random = new Random();
            string winner = array[random.Next(0, 3)];
            Console.WriteLine("Победителем стала команда "+winner);
        }
    }
}
