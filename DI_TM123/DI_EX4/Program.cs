using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX4
{
    internal class Program
    {
        public static void showMenu(int option)
        {
            switch (option)
            {
                case 1:
                    int year;
                    do
                    {
                        Console.WriteLine("Introduce un año");
                        year = int.Parse(Console.ReadLine());
                    }
                    while (year < 0 || year > 1000);
                    if (isBisiesto(year))
                    {
                        Console.WriteLine("El año {0} es bisiesto", year);
                    }
                    else
                    {
                        Console.WriteLine("El año {0} no es bisiesto", year);
                    }
                    break;
                case 2:
                    Console.WriteLine("Introduce un numero");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce un numero");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(sumRange(n1, n2));
                    break;
                case 3:
                    goto case 1;
                    break;
                    goto case 2;
                case 4:
                    Console.WriteLine("Salir");
                    break;
            }
        }

        public static bool isBisiesto(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        public static int? sumRange(int n1, int n2)
        {
            if (n2 > n1)
            {
                return null;
            }
            else
            {
                int counterSum = 0;
                for (int i = n1; i <= n2; i++)
                {
                    counterSum += i;
                }
                return counterSum;
            }
        }

        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Año Bisiesto");
            Console.WriteLine("2. Suma de rango de números");
            Console.WriteLine("3. Todas las opciones");
            Console.WriteLine("4. Salir");
            option = int.Parse(Console.ReadLine());
            showMenu(option);
        }
    }
}
