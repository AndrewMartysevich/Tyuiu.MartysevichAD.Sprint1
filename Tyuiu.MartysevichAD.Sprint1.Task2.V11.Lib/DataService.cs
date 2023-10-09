using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MartysevichAD.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int value, int valueTwo)
        {
            return value * 60 * 60 + valueTwo * 60;
        }
    }
}
