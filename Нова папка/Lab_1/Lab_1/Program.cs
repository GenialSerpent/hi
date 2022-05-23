﻿


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Дано три дійсних числа a, b, c . Знайти: y = max(min(a * b, a * c), min(a + b, a + c))

        static double getMax(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        static double getMin(double x, double y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Перше число = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Друге число = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Третє число = ");
            double c = Convert.ToDouble(Console.ReadLine());
            double y = getMax(getMin(a * b, a * c), getMin(a + b, a + c));
            Console.WriteLine($"y = {y}");

        // Задано 4 - х цифрове число n. Знайти середнє арифметичне найбільшої та найменшої цифр числа.

            Console.Write("Введіть число = ");
            int n = Convert.ToInt16(Console.ReadLine());
            int max = 0;
            int min = 10;

            while (n != 0)
            {
                int x = n % 10;
                if (x > max)
                {
                    max = x;
                }

                if (x < min)
                {
                    min = x;
                }
                n /= 10;
            }
            double s = ((double)max + min) / 2;
            Console.WriteLine("{0:f1}", s);
        }
    }
}
