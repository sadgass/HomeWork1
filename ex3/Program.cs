using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            var x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2");
            var x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            var y2 = Convert.ToDouble(Console.ReadLine());
            var r = Convert.ToDouble(Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)));
            
            Console.WriteLine("Расстояние между точками ="+"{0:F2}", r);

        }
    }
}
