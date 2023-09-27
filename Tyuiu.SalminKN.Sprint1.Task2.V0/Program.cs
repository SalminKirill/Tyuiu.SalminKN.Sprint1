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
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите значение");
            int x = Convert.ToInt32(Console.ReadLine());
            int res = ds.Sqr(x);
            Console.WriteLine("Результат:" + res);
            Console.ReadLine();
        }
    }
}
