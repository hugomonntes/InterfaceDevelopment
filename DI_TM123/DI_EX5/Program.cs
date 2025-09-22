#define OPTION
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
            if (num < 0 || num > 10)
            {
                return false;
            }

            resultado = num;
            for (int i = 0; i <= num; i++)
            {
                resultado *= i;
            }

            return true;
        }

        //b) Función que dibuja en posiciones aleatorias de la pantalla la cantidad de
        //asteriscos que se le pasa como parámetro.Lo harán entre las filas 1 y 10 y las
        //columnas 1 y 20. Si no se le pasa ningún parámetro dibujará 10 asteriscos(Usa
        //parámetros opcionales, no sobrecarga). Usa Console.SetCursorPosition para la
        //colocación.
        public static Random numRandom = new Random();
        public static void paintRandomPositions(int quantityAsterisk = 10)
        {
            for (int i = 1; i <= quantityAsterisk; i++)
            {
                Console.SetCursorPosition(numRandom.Next(1, 11), numRandom.Next(1, 21));
                Console.WriteLine("*");
            }
        }

        public static void Main(string[] args)
        {
            int resultado = 0;
#if OPTION
            Console.WriteLine("{0} {1}",factorial(5,ref resultado), resultado);// Probar resultado, comprobar 0!
#else
            paintRandomPositions();
#endif
            Console.ReadLine();
        }
    }
}
