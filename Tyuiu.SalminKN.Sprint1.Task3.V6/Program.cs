using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task3.V6.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Салмин К. Н. | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Операторы составного присваивания.                             *");
            Console.WriteLine("* Задание #3                                                           *");
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
            Console.WriteLine("* Расстояние до дачи (км); Количество бензина, которое потребляет      *");
            Console.WriteLine("* автомобиль на 100 км пробега; Цена одного литра бензина.             *");
            Console.WriteLine("************************************************************************");
            Console.Write("Введите расстояние до дачи в километрах:");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество бензина, потребляемое на 100км пробега:");
            double gasFlow = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите цену на литр бензина:");
            double gasPrice = Convert.ToDouble(Console.ReadLine());
            double res = ds.TravelCost(distance, gasFlow, gasPrice);
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************"); 
            Console.WriteLine($"* Цена за поезду до дачи и обратно составляет:{res}                   *");
            Console.WriteLine("************************************************************************");

            Console.ReadKey();
        }
    }
}
