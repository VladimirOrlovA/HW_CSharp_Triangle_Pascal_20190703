using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CSharp_Triangle_Pascal_20190703
{
    class Program
    {
        static void Main(string[] args)
        {
            int hight = 0, i = 0, j = 0;
            Console.WriteLine("Enter hight of triangle \"Pascal\"");
            hight = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < hight; i++)
            {
                for (j = 0; j <= (hight - i); j++) // делаем заполнение пробелами с левой стороны треугольника
                    Console.Write(" ");
                for (j = 0; j <= i; j++) // вставляем значения и пробелы между элементами треугольника
                {
                    Console.Write(" "); 
                    Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j))); //формула вычисления элементов треугольника
                }
                Console.WriteLine(); // переход на следующую строку
            }
            Console.ReadKey();
        }

        // функция вычисления факториала числа
        public static int Factorial(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
                x *= i;
            return x;
        }
    }
}
