using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task0.V0.Lib;

namespace Tyuiu.SalminKN.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 4;

            int x = 30 / 6 + 4;

            a++;

            x += b += a;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
