using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint1.Task2.V1.Lib;
namespace Tyuiu.YagodinVA.Sprint1.Task2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ягодин В. А. | АСОиУб-23-2";
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                        *");
            Console.WriteLine("* Задание #2                                                                              *");
            Console.WriteLine("* Вариант #1                                                                              *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович | АСОиУб-23-2                                  *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                 *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                             *");
            Console.WriteLine("*                                                                                         *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                        *");
            Console.WriteLine("*******************************************************************************************");

            int value;

            Console.WriteLine("Введите расстояние в километрах (целое число):");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                              *");
            Console.WriteLine("*******************************************************************************************");

            Console.WriteLine(ds.ConvertKmToM(value));

            Console.ReadKey();
        }
    }
}
