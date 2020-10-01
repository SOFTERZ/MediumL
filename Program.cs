using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Средний уровень :P
            try
            {
                const double x = 8.52;
                double y, a, b, c;
                Console.Write("Введите c:");
                c = double.Parse(Console.ReadLine());
                b = x + Math.Pow(c, 2);
                a = Math.Pow(Math.Sqrt(Math.Abs(b + c)), 3);
                y = Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(Math.Pow(a, 2)), 4);
                Console.WriteLine("y =" + y);
                Console.WriteLine("a =" + a);
                Console.WriteLine("b =" + b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}