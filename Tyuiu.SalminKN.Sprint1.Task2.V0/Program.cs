using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task2.V0.Lib;

namespace Tyuiu.SalminKN.Sprint1.Task2.V0
{
    class Program
    {
        public static int Main(string[] arg)
        {

            int a = 3;

            int b = --a + 2;

            int c = b;

            a = a + b + c;

            c = b++ + a;

            b = b - a;

            int x = a + b + c;

            Console.WriteLine(x);

            Console.ReadKey();
            return x;
        }
    }
}
