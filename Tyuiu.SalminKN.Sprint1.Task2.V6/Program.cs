using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task2.V6.Lib;

namespace Tyuiu.SalminKN.Sprint1.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Арифметические операторы в C#.                                 *");
            Console.WriteLine("* Задание #2                                                           *");
            Console.WriteLine("* Вариант #6                                                           *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Написать программу,которая запрашивает у пользователя исходные данные*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.          *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* В 1 киллометре 1000 метров...                                        *");
            Console.WriteLine("************************************************************************");
                
            Console.Write("Введите расстояние в метрах:");
            int metrs = Convert.ToInt32(Console.ReadLine());
            double res = ds.ConvertMToKm(metrs);
            Math.Round(res, 3);
            Console.WriteLine("************************************************************************");
            Console.WriteLine($"*                          РЕЗУЛЬТАТ:{res}                            *");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}
