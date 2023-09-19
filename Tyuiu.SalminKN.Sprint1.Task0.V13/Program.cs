using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task0.V13.Lib;

namespace Tyuiu.SalminKN.Sprint1.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                     *");
            Console.WriteLine("* Задание #1.0                                                         *");
            Console.WriteLine("* Вариант #1                                                           *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 24/(6*2)-24/6/4      *");
            Console.WriteLine("* и печатает результат на экране.                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* 24 / (6 * 2) - 24 / 6 / 4                                            *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadKey();
        }
    }
}
