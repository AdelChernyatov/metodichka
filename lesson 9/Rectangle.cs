using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Rectangle:Point
    {
        public override void Move(int num_1, int num_2)
        {
            Console.WriteLine("Вершина прямоугольника сместится по горизонтали: " + num_1 + " по вертикали: " + num_2);
        }
    }
}
