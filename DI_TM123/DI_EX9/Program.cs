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
            int option;
            bool optionCheck;
            do
            {
                do
                {
                    Console.WriteLine("1.- Añadir nuevo equipo");
                    Console.WriteLine("2.- Añadir varios equipos");
                    Console.WriteLine("3.- Elimina un dato por clave");
                    Console.WriteLine("4.- Mostrar coleccion completa(solo ips)");
                    Console.WriteLine("5.- Muestra un elemento de la coleccion (mostrar RAM o que no existe)");
                    Console.WriteLine("6.- Salir");
                    optionCheck = int.TryParse(Console.ReadLine(), out option) && (option > 0 && option <= 6);
                }
                while (!optionCheck);
                Ordenador pc = new Ordenador();
                switch (option)
                {
                    case 1:
                        string ip;
                        do
                        {
                            Console.WriteLine("Introduce la ip: ");
                            ip = Console.ReadLine();
                        }
                        while (!Ordenador.checkIP(ip));

                        Console.WriteLine("Introduce el nombre del pc: ");
                        pc.Nombre = Console.ReadLine();
                        bool memoriaValida;
                        int memoria;
                        do
                        {
                            Console.WriteLine("Introduce la memoria RAM: ");
                            memoriaValida = int.TryParse(Console.ReadLine(), out  memoria);
                            if (!memoriaValida)
                            { 
                                Console.WriteLine("Introduce una memoria válida");
                            }
                        }
                        while (!memoriaValida);

                        pc.MemoriaRam = memoria;
                        ipPorOrdenador.Add(ip, pc);
                        break;
                    case 2:
                        Console.WriteLine("Introduce la ip y la ram con este formato: xxx.xxx.xxx.xxx:ram,xxx.xxx.xxx.xxx:ram");
                        string ipRam = Console.ReadLine();
                        string[] ipConRam = ipRam.Split(",");
                        string[] ipSeparadoRam;
                        for (int i = 0; i < ipConRam.Length; i++)
                        {
                            ipSeparadoRam = ipConRam[i].Split(":");
                            bool ramIsNumber = int.TryParse(ipSeparadoRam[1], out int ram) && ram > 0;
                            if (Ordenador.checkIP(ipSeparadoRam[0]) && ramIsNumber)
                            {
                                pc.MemoriaRam = ram;
                                ipPorOrdenador.Add(ipSeparadoRam[0], pc);
                                Console.WriteLine($"IP: {ipSeparadoRam[0]} introducida!");
                            }
                            else
                            {
                                Console.WriteLine($"IP: {ipSeparadoRam[0]} no introducido! Error de formato");
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("Introduce la IP a eliminar: ");
                        string ipToCompare = Console.ReadLine();
                        bool checkIp = Ordenador.checkIP(ipToCompare);
                        if (checkIp && ipPorOrdenador.ContainsKey(ipToCompare))
                        {
                            ipPorOrdenador.Remove(ipToCompare);
                            Console.WriteLine($"Elemnto {ipToCompare} eliminado.");
                        }

                        break;

                    case 4:
                        foreach (var ips in ipPorOrdenador.Keys)
                        {
                            Console.WriteLine($"IP: {ips}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Introduce la IP para buscar la ram: ");
                        string ipToSearch = Console.ReadLine();
                        if (ipPorOrdenador.ContainsKey(ipToSearch))
                        {
                            Console.WriteLine(ipPorOrdenador[ipToSearch]);
                        } 
                        else
                        {
                            Console.WriteLine("Introduce una ip que exista!");
                        }
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
