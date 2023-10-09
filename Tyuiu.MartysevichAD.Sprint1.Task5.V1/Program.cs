using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint1.Task5.V1.Lib;

namespace Tyuiu.MartysevichAD.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                             *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).  *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x1, y1, x2, y2;

            Console.WriteLine("Введите координату x для первой точки");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y для первой точки");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x для второй точки");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y для второй точки");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Расстояние между точками = " + Convert.ToInt32(ds.DistanceBetweenDots(x1, x2, y1, y2)));

            Console.ReadLine();
        }
    }
}
