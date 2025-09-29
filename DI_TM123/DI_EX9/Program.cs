using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Ordenador> ipPorOrdenador = new Dictionary<string, Ordenador>();
            ipPorOrdenador.Add("ip", new Ordenador());
            foreach (KeyValuePair<string, Ordenador> ips in ipPorOrdenador)
            {
                Console.WriteLine(ips);
            }

            //Plantea un menú para nuevo equipos, elimina un dato(por clave), muestra de la
            //colección entera y muestra de un elemento de la colección(A partir de la clave
            //muestra el resto de los datos).
            //Al pedir datos se debe comprobar que la IP es válida y que la cantidad de RAM es
            //un entero positivo.

            int option = 0;
            do
            {
                Console.WriteLine("1.- Añadir nuevo equipo");
                Console.WriteLine("2.- Añadir varios equipos");
                Console.WriteLine("3.- Elimina un dato por clave");
                Console.WriteLine("4.- Mostrar coleccion completa(solo ips)");
                Console.WriteLine("5.- Muestra un elemento de la coleccion (mostrar RAM o que no existe)");
                Console.WriteLine("6.- Salir");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    default:
                        Console.WriteLine("Elija una opcion del menu");
                        break;
                }
            }
            while (option != 6);

        }
    }
}
