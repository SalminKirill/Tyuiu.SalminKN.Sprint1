﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SalminKN.Sprint1.Task3.V0.Lib;
namespace Tyuiu.SalminKN.Sprint1.Task3.V0
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
            Console.WriteLine("* Вариант #0                                                           *");
            Console.WriteLine("* Выполнил: Салмин Кирилл Николаевич | АСОиУБ-23-1                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ЗАДАНИЕ:                                                             *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Найти площадь прямоугольника.                                        *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Прямоугольник со сторонами A и Б                                     *");
            Console.WriteLine("************************************************************************");

            Console.Write("Введите первую сторону прямоугольника:");
            double i = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите вторую сторону прямоугольника:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(i, y);

            Console.WriteLine("************************************************************************");
            Console.WriteLine($"*                          РЕЗУЛЬТАТ:{res}                               *");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();

        }
    }
}
