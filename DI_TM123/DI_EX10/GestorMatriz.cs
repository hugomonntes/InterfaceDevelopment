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
            if (indiceFila < 0 || indiceFila >= Matriz.GetLength(0)) // GetLength me devuelve el numero de filas en este caso
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

        //Método SumaColumna.Se le pasa una parámetro entero que representa una
        //columna y tendrá otro parámetro por referencia pero de salida (out) donde
        //devuelve el resultado de la suma de los elementos de la columna.Devolverá true si
        //el índice es correcto o false si no lo es.

        public bool sumaColumna(int indiceColumna, ref int resultadoSuma) 
        {
            if (indiceColumna < 0 || indiceColumna >= Matriz.GetLength(1))
            {
                return false;
            }

            resultadoSuma = 0;
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {   
                resultadoSuma += Matriz[i, indiceColumna];
            }
            return true;
        }

        //Método SumaMatriz: tiene como parámetro un object. Si el object es un array
        //bidimensional de int o double o un objeto del tipo GestorMatriz y es del mismo
        //tamaño que Matriz, se suma elemento a elemento y el resultado se devuelve.En
        //otro caso lanza una excepción creada por ti denominada MatrizException.

        public void SumaMatriz(object obj)
        {
            if (obj is int[,] matrizInts && (obj is GestorMatriz && matrizInts.Length != Matriz.Length))
            {
                if ()
                {
                    
                }
            }
        }

    }
}
