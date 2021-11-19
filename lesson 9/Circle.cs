using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Circle : Point
    {
        public override void Move (int num_1,int num_2)
        {
            Console.WriteLine("Центра окружности сместится по горизонтали: "+num_1+" по вертикали: "+num_2 );
        }
    }
}
