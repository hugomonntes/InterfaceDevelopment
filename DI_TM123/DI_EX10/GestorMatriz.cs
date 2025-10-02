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

        public GestorMatriz(int numeroFilas, int numeroColumnas)
        {
            Matriz = new int[randomNumber(-5,20), randomNumber(-5, 20)];
        }

        public GestorMatriz() : this(3, 4) { }

        //public (int, bool) sumaFila(int numeroFilas)
        //{
        //    return numeroFilas > 0;
        //}

        public int randomNumber(int minRangue, int maxRangue)
        {
            Random random = new Random();
            return random.Next(minRangue, maxRangue);
        }
    }
}
