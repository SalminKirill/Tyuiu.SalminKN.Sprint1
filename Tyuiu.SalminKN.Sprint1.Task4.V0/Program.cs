using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task4.V0.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Class Math                                                     *");
            Console.WriteLine("* Задание #4                                                           *");
            Console.WriteLine("* Вариант #0                                                           *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*             ______1______                                            *");
            Console.WriteLine("*             x ^ 2 + y ^ 2                                            *");
            Console.WriteLine("************************************************************************");


            Console.Write("Введите значение х:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение у:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine($"* Цена за поезду до дачи и обратно составляет:{res}                   *");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}
