using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task4.V6.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Class Math                                                       *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу,которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*            ln(xy)                                                      *");
            Console.WriteLine("*        ---------------                                                 *");
            Console.WriteLine("*         x - √ 1 + y^2                                                  *");
            Console.WriteLine("**************************************************************************");

            double x, y;
            
            Console.WriteLine("Введите первое значение");

            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите второе значение");
            y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x,y);
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine($"* Выражение равняется:{res}                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
