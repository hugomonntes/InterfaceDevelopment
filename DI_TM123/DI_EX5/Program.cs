using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX5
{
    internal class Program
    {
        //a) Función que se le pase un número y calcula el factorial del mismo.Si el número
        //es negativo o mayor de 10 la función devuelve false. En caso contrario devuelve
        //true. El resultado del factorial irá en un parámetro por referencia.

        public static bool factorial(int num, ref int resultado)
        {
            resultado = num;
            for (int i = num - 1; i > 0; i++)
            {
                resultado *= i;
            }
            return num < 0 || num > 10 ? false : true;
        }

        //b) Función que dibuja en posiciones aleatorias de la pantalla la cantidad de
        //asteriscos que se le pasa como parámetro.Lo harán entre las filas 1 y 10 y las
        //columnas 1 y 20. Si no se le pasa ningún parámetro dibujará 10 asteriscos(Usa
        //parámetros opcionales, no sobrecarga). Usa Console.SetCursorPosition para la
        //colocación.
        public static int randomNumber(Random numRandom)
        {
            return numRandom.Next(10);
        }

        public static void paintRandomPositions(int quantityAsterisk)
        {
            for (int i = 1; i <= quantityAsterisk; i++) // Columnas
            {
                Console.Write("*");
                for (int j = 1; j <= quantityAsterisk; j++) // Filas
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            paintRandomPositions(10);
            Console.WriteLine(randomNumber(new Random()));
        }
    }
}
