using System;
namespace MenuEstandar;
    class Program
    {
        static void Main(string[] args)
        {
          bool salir = false;
          do
          {
            Console.Clear();
            Console.WriteLine("Bienvenido al menú estandar");
            Console.WriteLine("1. Opción 1");
            Console.WriteLine("2. Opción 2");
            Console.WriteLine("3. Opción 3");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Seleccionó la opción 1");
                    Console.Write("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Seleccionó la opción 2");
                    Console.Write("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Seleccionó la opción 3");
                    Console.Write("presione cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
                case 0:
                    salir = true;
                    Console.WriteLine("Saliendo del menú");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
          }while(!salir);
        }
    }
