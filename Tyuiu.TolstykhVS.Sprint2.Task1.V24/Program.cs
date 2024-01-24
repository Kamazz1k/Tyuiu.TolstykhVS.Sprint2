using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolstykhVS.Sprint2.Task1.V24.Lib; 
namespace Tyuiu.TolstykhVS.Sprint2.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            int a = 325, b = 325, c = 242, d = 324;
            bool[] res = new bool[6];
            res = dataService.GetLogicOperations(a,b,c,d);

            Console.Title = "Спринт #2 | Выполнил: Толстых В.С | СмартБ 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Толстых Вячеслав Сергеевич | СмартБ 23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* и арифметических выражений,                                             *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* ((True, False, True, False, True, False), при a = 325, b = 325,         *");
            Console.WriteLine("* c = 242, d = 324                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("A =" + a);
            Console.WriteLine("B =" + b);
            Console.WriteLine("C =" + c);
            Console.WriteLine("D =" + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
