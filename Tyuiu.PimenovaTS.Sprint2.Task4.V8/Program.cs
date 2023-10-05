using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint2.Task4.V8.Lib;

namespace Tyuiu.PimenovaTS.Sprint2.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Пименова Т. С. | ИИПб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Тернарный оператор                                                 *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #8                                                               *");
            Console.WriteLine("* Выполнила: Пименова Т. С. | ИИПб-23-2                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x, y с *");
            Console.WriteLine("* клавиатуры                                                               *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
