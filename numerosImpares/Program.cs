using System;
namespace NumerosImpares;
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i+" es impar");
                }
            }
        }
    }
