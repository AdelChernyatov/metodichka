using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class Program
    {
       /* public enum Country 
        {
            Россия,
            Франция,
            Китай,
            Украина
        }*/
        static void Main(string[] args)
        {
            string[] teams = { "Россия", "Франция", " Китай", "Украина" };
            int i = 0;

            while (i < 7)
            {
                i++;
                Console.WriteLine("Введите игру:пляж|море|рыбалка|почтальоны|мышеловка|горка|гонки");
                string change = Console.ReadLine().ToLower();
                switch (change) 
                {
                    case "пляж":
                        Console.WriteLine("Начинаем игру <Пляж>");
                        Beach beach = new Beach();
                        beach.PLay_games(teams);
                        break;
                    case "мышеловка":
                        Console.WriteLine("Начинаем игру <Мышеловка>");
                        Mouse_keep mouse = new Mouse_keep();
                        mouse.PLay_games(teams);
                        break;
                    case "море":
                        Console.WriteLine("Начинаем игру <Море>");
                         Sea sea = new Sea();
                        sea.PLay_games(teams);
                        break;
                    case "рыбалка":
                        Console.WriteLine("Начинаем игру <Рыбалка>");
                        Fishing fishing = new Fishing();
                        fishing.PLay_games(teams);
                        break;
                    case "почтальоны":
                        Console.WriteLine("Начинаем игру почтальоны");
                        Postman postman = new Postman();
                        postman.PLay_games(teams);
                        break;
                    case "горка":
                        Console.WriteLine("Начинаем игру горку");
                        Slide slide = new Slide();
                        slide.PLay_games(teams);
                        break;
                    case "гонки":
                        Console.WriteLine("Начинаем игру гонки");
                        Car_race car = new Car_race();
                        car.PLay_games(teams);
                        break;
                    default:
                        Console.WriteLine("Вы ввели не ту игру");
                        break;
                }
                Console.WriteLine("");
            }
                  
        }
    }
}
