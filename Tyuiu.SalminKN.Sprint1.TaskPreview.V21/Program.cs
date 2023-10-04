using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.TaskPreview.V21.Lib;
namespace Tyuiu.SalminKN.Sprint1.TaskPreview.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #1 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: SprintReview                                                   *");
            Console.WriteLine("* Задание #1.0                                                         *");
            Console.WriteLine("* Вариант #21                                                          *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет выражение                      *");
            Console.WriteLine("* и печатает результат на экране.                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* (y^x)/(cosx-(x/3))+((sinx^2)+cosy) / (cosx-siny) * tgxy              *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Round(ds.Calculate(x, y), 3));

            Console.ReadKey();
        }
    }
}
