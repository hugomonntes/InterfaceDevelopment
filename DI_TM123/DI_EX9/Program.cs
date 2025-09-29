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
                bool isChecked;
                switch (option)
                {
                    case 1:
                        Ordenador pc = new Ordenador();
                        string ip;
                        do
                        {
                        Console.WriteLine("Introduce la ip: ");
                        ip = Console.ReadLine();
                        if (Ordenador.checkIP(ip))
                        {
                            isChecked = true;
                        }
                        else
                        {
                            isChecked = false;
                        }
                        }
                        while (!isChecked);

                        Console.WriteLine("Introduce el nombre del pc: ");
                        string nombrePC = Console.ReadLine();
                        pc.Nombre = nombrePC;

                        Console.WriteLine("Introduce la memoria RAM: ");
                        int.TryParse(Console.ReadLine(), out int memoria);
                        pc.MemoriaRam = memoria;

                        ipPorOrdenador.Add(ip, pc);
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:
                        foreach (KeyValuePair<string, Ordenador> ips in ipPorOrdenador)
                        {
                            Console.WriteLine(ips);
                        }
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
