using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YagodinVA.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            string s = number.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new String(ar);
            number = Convert.ToDouble(s);
            return number;
        }
    }
}
