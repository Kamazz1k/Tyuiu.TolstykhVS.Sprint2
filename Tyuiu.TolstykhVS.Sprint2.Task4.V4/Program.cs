using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolstykhVS.Sprint2.Task4.V4.Lib;

namespace Tyuiu.TolstykhVS.Sprint2.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Толстых В.С | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Толстых Вячеслав Сергеевич | СМАРТб-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных x, y с клавиатуры                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y;

            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var z = ds.Calculate(x, y);
            Console.WriteLine("Переменная Z будет равна " + z);
            Console.ReadKey();
        }
    }
}
