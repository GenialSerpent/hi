using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project
{
    internal class Program
    {
        // Дано вектори дійсних чисел a, b∈ Rn. З‘ясувати, чи є вони ортогональні
        static double[] v1(int n)
        {
            double[] x = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < x.GetLength(0); i++)
                x[i] = rnd.NextDouble();
            return x;
        }
        static void printV1(double[] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
                Console.Write(x[i] + "\t");
            Console.ReadLine();
        }

        // Дана дійсна матриця порядку (n*n). Усі елементи вище протилежної діагоналі замінити нулем.
        static double[,] v2(int n)
        {
            double[,] x = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                    x[i, j] = rnd.NextDouble();
            return x;
        }
        static void printV2(double[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                    Console.Write(x[i, j] + "\t");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Кількість ел. в масиві: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] a1 = v1(n);
            Console.Write("a = ");
            printV1(a1);

            double[] b = v1(n);
            Console.Write("b = ");
            printV1(b);

            double[] c;
            c = new double[n];
            for (int i = 0; i < n; i++)
                c[i] = a1[i] * b[i];

            double sum = 0;
            for (int i = 0; i < c.GetLength(0); i++)
                sum += c[i];
            Console.WriteLine($"Скалярний добуток = {sum}");

            if (sum == 0)
                Console.WriteLine("Вектори ортогональні");
            else
                Console.WriteLine("Вектори не ортогональні");

            Console.Read();

            // ---------------------------------------------------------------------

            Console.Write("Кількість ел. в двохвимірному масиві: ");
            int m = Convert.ToInt32(Console.ReadLine());

            double[,] a2 = v2(m);
            Console.Write("a = ");
            printV2(a2);

            double[,] s;
            s = new double[m, m];

            for (int i = 0; i < s.GetLength(0); i++)
                for (int j = 0; j < s.GetLength(1) - i - 1; j++)
                    a2[i, j] = s[i, j];
            printV2(a2);

            Console.Read();
        }
    }
}