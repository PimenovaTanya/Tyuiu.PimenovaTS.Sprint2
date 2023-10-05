using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint2.Task5.V13.Lib;

namespace Tyuiu.PimenovaTS.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Пименова Т. С. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Пименова Т. С. | ИИПб-23-2                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: дата некоторого дня *");
            Console.WriteLine("* характеризуется тремя натуральными числами. По заданным g, m, n         *");
            Console.WriteLine("* определить дату следующего дня. Заданный год является високосным.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int g, m, n;

            Console.WriteLine("Введите значение G: ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение M: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N: ");
            n = Convert.ToInt32(Console.ReadLine());

            double res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && (n < 1 || n > 31)) || ((m == 4 || m == 6 || m == 9 || m ==11) && (n < 1 || n > 30)) || (m == 29 && (n < 1 || n > 29)) || (m < 1 || m > 12))
            {
                Console.WriteLine("Введено неверное значение!");
            }
            else
            {
                Console.WriteLine(res);
            }
            

            Console.ReadKey();
        }
    }
}
