using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MartysevichAD.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double half1 = x2 - x1;
            double half2 = y2 - y1;
            return Convert.ToInt32(Math.Sqrt(Math.Pow(half1, 2) + Math.Pow(half2, 2)));
        }
    }
}
