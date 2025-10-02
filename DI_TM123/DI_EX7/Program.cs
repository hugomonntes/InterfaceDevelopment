using System;
using System.Collections.Generic;
using System.Reflection;

namespace DI_EX7
{
#nullable disable
    public class Program
    {
        static void Main(string[] args)
        {
            List<Astro> coleccionAstros = new List<Astro>();
            int opcion = 0;

            do
            {
                Console.WriteLine("1. Añadir Planeta");
                Console.WriteLine("2. Añadir Cometa");
                Console.WriteLine("3. Mostrar Datos");
                Console.WriteLine("4. Incrementa / Decrementa satélites");
                Console.WriteLine("5. Eliminar no terraformables");
                Console.WriteLine("6. Salir");

                string entrada = Console.ReadLine();
                opcion = int.TryParse(entrada, out int valor) ? valor : -1;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Es gaseoso? (S/N)");
                        bool isGaseoso = (Console.ReadLine() ?? "N").ToUpper() == "S";

                        Console.WriteLine("Introduce el nombre:");
                        string nombrePlaneta = Console.ReadLine() ?? "";

                        Console.WriteLine("Introduce el radio:");
                        int.TryParse(Console.ReadLine(), out int radioPlaneta);

                        Console.WriteLine("Introduce cantidad de lunas:");
                        int.TryParse(Console.ReadLine(), out int numLunas);

                        coleccionAstros.Add(new Planeta(nombrePlaneta, radioPlaneta, isGaseoso, numLunas));  //trycatch
                        break;

                    case 2:
                        Console.WriteLine("Introduce el nombre:");
                        string nombreCometa = Console.ReadLine() ?? "";

                        Console.WriteLine("Introduce el radio:");
                        int.TryParse(Console.ReadLine(), out int radioCometa);

                        Cometa c = new Cometa();
                        coleccionAstros.Add(c);
                        c.Nombre = nombreCometa;
                        c.Radio = radioCometa;
                        break;

                    case 3:
                        foreach (var astro in coleccionAstros)
                        {
                            if (astro is Planeta planeta)//TODO habitable para todos y usa {}
                                Console.WriteLine(planeta.ToString());
                            else if (astro is Cometa cometa)
                                Console.WriteLine($"Cometa {cometa.Nombre}, Habitable: {cometa.esHabitable()}");
                        }
                        break;

                    case 4: //Index Of
                        Console.WriteLine("Introduce el nombre del Astro: ");
                        string nombreAstro = Console.ReadLine() ?? "";

                        Planeta auz = new()
                        {
                            Nombre = nombreAstro
                        };
                        int index = -1; // Pongo menos uno para cuando no me encuntre nada
                                index = coleccionAstros.IndexOf(auz);
                        for (int i = 0; i < coleccionAstros.Count(); i++)
                        {
                            if (coleccionAstros[index] is Planeta planetaAstro && coleccionAstros[i].Nombre == nombreAstro)
                            {
                                Console.WriteLine("Incrementar o Decrementar? +/-");
                                string eleccion = Console.ReadLine() ?? "";

                                if (eleccion == "+")
                                {
                                    planetaAstro++;
                                    coleccionAstros[index] = planetaAstro;
                                }
                                else if (eleccion == "-")
                                {
                                    planetaAstro--;
                                    coleccionAstros[index] = planetaAstro;
                                }
                                else
                                {
                                    Console.WriteLine("Opción no válida.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el planeta");
                            }
                        }
                        break;

                    case 5:
                        for (int i = 0; i < coleccionAstros.Count(); i++)//TODO comprobar interface. Revisar.
                        {
                            if (coleccionAstros[i] is Cometa || coleccionAstros[i] is Planeta planeta && !planeta.esHabitable())
                            {
                                coleccionAstros.Remove(coleccionAstros[i]);
                            }
                            i--;
                        }
                        Console.WriteLine("Eliminados los no terraformables.");
                        break;
                }

            } while (opcion != 6);
        }
    }
}
