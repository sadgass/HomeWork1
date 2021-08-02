using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            var age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост");
            var weight = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            var height = Console.ReadLine();
            Console.WriteLine($"{name},{surname},{age},{weight},{height}");
        }
    }
}
