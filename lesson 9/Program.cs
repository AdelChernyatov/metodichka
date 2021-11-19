using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Program
    {
        public static void Output_Circle(Circle c) 
        {
            Console.WriteLine("Введите цвет окружности");
            string colour = Console.ReadLine();
            Console.WriteLine("Введите число на которое сдвинется окружность по горизонтали и вертикали");
            int num_1 = Checked();
            int num_2 = Checked();
            Console.WriteLine("Введите радиус круга");
            int radius = Checked();
            c.Colour(colour);
            c.Move(num_1,num_2);
            c.Get_Square(radius);            
        }
        public static void Output_Point(Point p)
        {
            Console.WriteLine("Введите цвет точки");
            string colour = Console.ReadLine();
            Console.WriteLine("Введите число на которое сдвинется точка по горизонтали и вертикали");
            p.Move(Checked(), Checked());
            p.Colour(colour);
        }
        public static void Output_Rectangle(Rectangle r)
        {
            Console.WriteLine("Введите цвет прямоугольника");
            string colour = Console.ReadLine();
            Console.WriteLine("Введите число на которое сдвинется фигура по горизонтали и вертикали");
            int num_1 = Checked();
            int num_2 = Checked();
            Console.WriteLine("Введите стороны прямоугольника");
            int side_1 = Checked();
            int side_2 = Checked();
            r.Colour(colour);
            r.Move(num_1,num_2);
            r.Get_Square(side_1,side_2);
        }
        static int Checked() 
        {
            int n = 0;
            if (int.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Acipher p = new Acipher();
            Console.WriteLine("Вы хотите <закодировать> или <декодировать>");
            string answer = Console.ReadLine().ToLower();
            switch (answer) 
            {
                case "закодировать":
                    Console.WriteLine("Введите строку");
                    p.Encode(Console.ReadLine());
                    break;
                case "декодировать":
                    Console.WriteLine("Введите строку");
                    p.Decode(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Неверно ввели данные");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Шифр номер 2");
            BCipher t = new BCipher();
            Console.WriteLine("Вы хотите <закодировать> или <декодировать>");
            string answer_new = Console.ReadLine().ToLower();
            switch (answer_new)
            {
                case "закодировать":
                    Console.WriteLine("Введите строку");
                    t.Encode(Console.ReadLine());
                    break;
                case "декодировать":
                    Console.WriteLine("Введите строку");
                    t.Decode(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Неверно ввели данные");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Task2");
            // Figure k = new Figure();
            Console.WriteLine("Выберите фигуру:окружность|точка|прямоугольник");
            switch (Console.ReadLine().ToLower()) 
            {
                case "окружность":
                    Circle c = new Circle();
                    Output_Circle(c);
                    break;
                case "точка":
                    Point point= new Point();
                    Output_Point(point);
                    break;
                case"прямоугольник":
                    Rectangle r = new Rectangle();
                    Output_Rectangle(r);
                    break;
                default:
                    Console.WriteLine("Вы ввели не ту фигуру");
                    break;
            }
            
            
        }
    }
}
