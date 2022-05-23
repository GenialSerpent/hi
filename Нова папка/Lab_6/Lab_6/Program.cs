using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class TStructureArray
    {
        public double[] Array { get; set; }
        public TStructureArray(double[] args)
        {
            Array = new double[args.Length];
            Array = args;
        }
        public override string ToString()
        {
            Console.WriteLine('[');
            for (int i = 0; i < Array.Length; i++)
                Console.Write($"{Array[i]} ");
            Console.WriteLine(']');
            return "";
        }
        public void append(double n)
        {
            double[] newArray = new double[Array.Length + 1];
            for (int i = 0; i < Array.Length; i++)
                newArray[i] = Array[i];
            newArray[newArray.Length - 1] = n;
            Array = new double[newArray.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = newArray[i];
            }
        }
        public void delete()
        {
            double[] newArray = new double[Array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = Array[i];
            Array = new double[newArray.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = newArray[i];
            }
        }
        public void ToFind(double n)
        {
            Console.Write('(');
            for (int i = 0; i < Array.Length; i++)
                if (Array[i] == n)
                    Console.Write($"{i} ");
            Console.WriteLine(')');
        }
    }
    public class TArray : TStructureArray
    {
        public TArray(double[] args) : base(args)
        {
        }
    }
    public class TVArray : TStructureArray
    {
        public TVArray(double[] args) : base(args)
        {
            Array = new double[args.Length];
            Array = args;
            double a;
            for (int i = 0; i < Array.Length; i++) 
                for (int j = 0; j < Array.Length - 1 - i; j++)
                    if (Array[j] > Array[j + 1])
                    {
                        a = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = a;
                    }

        }
    }
}
