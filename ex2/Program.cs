using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес");
            double m = Convert.ToDouble(Console.ReadLine());
            var i = m / (h * h);
            Console.WriteLine("Индекс массы вашего тела = " + i);



        }
    }
}
