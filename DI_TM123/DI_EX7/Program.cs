using System;
using System.Collections.Generic;

namespace DI_EX7
{
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

                Console.Write("Elige una opción: ");
                Console.WriteLine("0" ?? "Hugo");
                Console.WriteLine(null ?? "Hugo");
                Console.WriteLine("" ?? "Hugo");



                string entrada = Console.ReadLine() ?? "";
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

                        coleccionAstros.Add(new Planeta(nombrePlaneta, radioPlaneta, isGaseoso, numLunas));
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
                            if (astro is Planeta planeta)
                                Console.WriteLine(planeta.ToString());
                            else if (astro is Cometa cometa)
                                Console.WriteLine($"Cometa {cometa.Nombre}, Habitable: {cometa.esHabitable()}");
                        }
                        break;

                    case 4:
                        bool flag = true;
                        do
                        {
                            Console.WriteLine("Introduce el nombre del Astro: ");
                            string nombreAstro = Console.ReadLine() ?? "";
                            foreach (var astro in coleccionAstros)
                            {
                                if (astro is Planeta planetaAstro)
                                {
                                    Console.WriteLine("Quieres Incrementar o Decrementar? +/-");
                                    string eleccion = Console.ReadLine() ?? "";
                                    if (eleccion == "+")
                                    {
                                        planetaAstro.Satelites++;
                                        flag = true;
                                    }
                                    else if (eleccion == "-")
                                    {
                                        planetaAstro.Satelites--;
                                        flag = true;
                                    }
                                    else
                                    {
                                        flag = false;
                                    }
                                }
                            }
                        }
                        while (!flag);
                        break;

                    case 5:
                        foreach (var astro in coleccionAstros)
                        {
                            if (astro is Cometa cometa && !cometa.esHabitable())
                            {
                                coleccionAstros.Remove(astro);
                            }
                        }
                        Console.WriteLine("Eliminados los no terraformables.");
                        break;
                }

            } while (opcion != 6);
        }
    }
}
