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
            for (int i = num - 1; i > 0; i++)
            {
                num *= i;
            }
            resultado = num;
            return num < 0 || num > 10 ? false : true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
