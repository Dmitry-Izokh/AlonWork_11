using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение коэффициента k = ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение коэффициента b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            

            LinearEquation Linear = new LinearEquation(k, b);
            Console.WriteLine(Linear.Root());
            Console.ReadKey();

        }
    }
}
