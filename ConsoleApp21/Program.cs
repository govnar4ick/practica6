using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            Console.WriteLine("введите x");
            x = Convert.ToInt32(Console.ReadLine());
            double a = 4*Math.Sin(x)*5*Math.Sin(x);
            Console.WriteLine("функция равна =" + a);
            Console.ReadLine();
        }
    }
}
