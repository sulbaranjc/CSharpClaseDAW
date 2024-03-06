using System;
namespace SumaDeNumeros;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int num1, num2, suma;
            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("La suma de los números es: " + suma);
        }
    }
