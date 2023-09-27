using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task1.V16.Lib;

namespace Tyuiu.SalminKN.Sprint1.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложений                 *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* вычисляет результат по формуле x*5*y+2*a и печатает его на экране.     *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* x * 5 * y + 2 * a                                                      *");
            Console.WriteLine("**************************************************************************");

            double x, y, z;
            int res;
            Console.WriteLine("Введите первое значение");

            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите второе значение");
            y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите третье значение");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"                              *РЕЗУЛЬТАТ:{res = Convert.ToInt32(ds.Calculate(x, y, z))}*");
            Console.WriteLine("**************************************************************************");

            Console.ReadLine();

        }
    }
}
