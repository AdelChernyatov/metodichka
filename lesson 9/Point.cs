using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Point:Figure,ISquare,IMove
    {
        public override void Colour(string colour)
        {
            Console.WriteLine("Цвет обЪекта: " + colour);   
        }
        public void Get_Square(int r) 
        {
            Console.WriteLine("Площадь окружности : "+ Math.Round(Math.PI*r*r),2);
        }
        public void Get_Square(int side_1, int side_2) 
        {
            Console.WriteLine("Площадь прямоугольника : " +side_2 * side_1);
        }
        public virtual void Move(int num_1,int num_2) 
        {
            Console.WriteLine("Координата точки изменилась по горизонтали на: "+num_1+" по вертикали: "+num_2);
        }
    }
}
