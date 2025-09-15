using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Año Bisiesto");
            Console.WriteLine("2. Suma de rango de números");
            Console.WriteLine("3. Todas las opciones");
            Console.WriteLine("4. Salir");
            option = int.Parse(Console.ReadLine());
        }

        public static void showMenu(int opcion)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Introducir funcionalidad año bisiesto")
                case 2:
                    Console.WriteLine("Introducir funcionalidad suma rangos")
                case 3:
                    Console.WriteLine("Introducir funcionalidad todas las opciones")
                case 4:
                    Console.WriteLine("Salir")
            }
        }

        public static void anoBisiesto()
        {
            Console.WriteLine("Introduce un año");

        }
    }
}
