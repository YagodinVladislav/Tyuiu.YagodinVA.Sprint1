using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.YagodinVA.Sprint1.Task7.V11.Lib;

namespace Tyuiu.YagodinVA.Sprint1.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ягодин В А| АСОиУб-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #11                                                                *");
            Console.WriteLine("* Выполнил:  Ягодин Владислав Александрович| АСОиУб-23-2                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу,                                                        *");
            Console.WriteLine("* которая вычисляет математическое выражение по исходным значениям данных,   *");
            Console.WriteLine("* вводимых пользователем.                                                    *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*          2         2                                                       *");
            Console.WriteLine("*     cos(x ) + sin(y )      xy - 12                                         *");
            Console.WriteLine("* z = ------------------  - ------------                                     *");
            Console.WriteLine("*     sin(y) + 1             15 + cos(x)                                     *");
            Console.WriteLine("*                                                                            *");

            double x, y;

            Console.Write("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());
             
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(dataService.Calculate(x, y));

            Console.ReadKey();
        }
    }
}