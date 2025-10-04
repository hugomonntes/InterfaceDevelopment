using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX10
{
    internal class GestorMatriz
    {
        public int[,] Matriz;
        private static Random random = new Random();
        public GestorMatriz(int numeroFilas, int numeroColumnas)
        {
            Matriz = new int[numeroFilas, numeroColumnas];
            for (int i = 0; i < numeroFilas; i++)
            {
                for (int j = 0; j < numeroColumnas; j++)
                {
                    Matriz[i, j] = random.Next(-5, 21);
                }
            }
        }

        public GestorMatriz() : this(3, 4) { }

        //El booleano devuelve true si el parámetro es un índice válido
        //y false si no lo es.En caso de índice válido el entero devuelto es la suma de los
        //elementos de la fila. Si no devuelve 0.
        public (int, bool) sumaFila(int indiceFila)
        {
            if (indiceFila < 0 || indiceFila >= Matriz.GetLength(0))
            {
                return (0, false);
            }
            int suma = 0;
            for (int j = 0; j < Matriz.GetLength(1); j++)
            {
                suma += Matriz[indiceFila, j];
            }

            return (suma, true);
        }

        public int randomNumber(int minRangue, int maxRangue)
        {
            Random random = new Random();
            return random.Next(minRangue, maxRangue);
        }
    }
}
