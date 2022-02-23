using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x; // вхідний аргумент
            double a,b,c; // вхідні параметри
            double F = 0; // результат обчислення виразу
            
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

          
            if (c < 0 && b != 0)
                F = a * Math.Pow(x, 2) + Math.Pow(b, 2) * x;
            if (c > 0 && b == 0)
                F = (x + a) / (x + c);
            if (!(c < 0 && b != 0) && !(c > 0 && b == 0))
                F = x / c;

            Console.WriteLine($"F = {F}");


            Console.ReadKey();


        }
    }
}
