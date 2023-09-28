using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.YagodinVA.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: ЯГОДИН В. А. | АСОиУб-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #2                                                                 *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович | АСОиУб-23-2                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,    *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                   *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int k;

            Console.Write("Введите значение K: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine($"Это {ds.Calculate(k)} день недели");

            Console.ReadKey();
        }
    }
}