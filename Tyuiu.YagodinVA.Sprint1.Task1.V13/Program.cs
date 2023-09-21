﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint1.Task1.V13.Lib;

namespace Tyuiu.YagodinVA.Sprint1.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: ЯГОДИН В. A. | АСОиУб-23-2";
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                       *");
            Console.WriteLine("* Задание #1                                                                             *");
            Console.WriteLine("* Вариант #13                                                                            *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович| АСОиУб-23-2                                  *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                *");
            Console.WriteLine("* вычисляет результат по форумле x / (0.5 * x) и печатает его на экран                   *");
            Console.WriteLine("*                                                                                        *");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            Console.WriteLine("******************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}