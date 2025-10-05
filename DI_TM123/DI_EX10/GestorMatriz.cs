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

        //c) Método SumaFila: se le pasa un parámetros entero y devuelve una tupla con un
        //entero y un booleano. El booleano devuelve true si el parámetro es un índice válido
        //y false si no lo es. En caso de índice válido el entero devuelto es la suma de los
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
            if ((obj is int[,] matrizInts && matrizInts.GetUpperBound(0) == Matriz.GetUpperBound(0) && matrizInts.GetUpperBound(1) == Matriz.GetUpperBound(1)) || (obj is GestorMatriz))
            {
                int sumaTotal = 0;
                for (int i = 0; i < matrizInts.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizInts.GetLength(1); j++)
                    {
                        sumaTotal += matrizInts[i, j];
                    }
                }
            }
            else if ((obj is double[,] matrizDouble && matrizDouble.GetUpperBound(0) == Matriz.GetUpperBound(0) && matrizDouble.GetUpperBound(1) == Matriz.GetUpperBound(1)) || (obj is GestorMatriz))
            {
                double sumaTotal = 0;
                for (int i = 0; i < matrizDouble.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizDouble.GetLength(1); j++)
                    {
                        sumaTotal += matrizDouble[i, j];
                    }
                }
            }
        }

    }
}

//Ejercicio 10
//Se desea realizar una clase para gestionar matrices bidimensionales denominada
//GestorMatriz. Dispondrá de una propiedad tipo array bidimensional de enteros
//denominada Matriz y los siguientes métodos:

//a) Un constructor con dos parámetros enteros que representan el número de filas y
//número de columnas. La propiedad Matriz se crea del n.º de filas y columnas
//indicado por los parámetros y se rellena con números aleatorios entre -5 y 20
//ambos incluidos.

//b) Sobrecargado otro constructor sin parámetros que, llamando al anterior,
//inicializa una tabla de 3 filas y 4 columnas.

//c) Método SumaFila: se le pasa un parámetros entero y devuelve una tupla con un
//entero y un booleano. El booleano devuelve true si el parámetro es un índice válido
//y false si no lo es. En caso de índice válido el entero devuelto es la suma de los
//elementos de la fila. Si no devuelve 0.

//d) Método SumaColumna. Se le pasa una parámetro entero que representa una
//columna y tendrá otro parámetro por referencia pero de salida (out) donde
//devuelve el resultado de la suma de los elementos de la columna. Devolverá true si
//el índice es correcto o false si no lo es.

//e) Método SumaMatriz: tiene como parámetro un object. Si el object es un array
//bidimensional de int o double o un objeto del tipo GestorMatriz y es del mismo
//tamaño que Matriz, se suma elemento a elemento y el resultado se devuelve. En
//otro caso lanza una excepción creada por ti denominada MatrizException.

//f ) Método medias: Tiene un parámetro booleano. Si es true devuelve un vector de
//doubles con la media de cada una de las filas. Si es false devuelve un vector de
//doubles con la media de cada una de las columnas.

//g) Método estático MostrarMatriz: Parámetro tipo array bidimensional de cualquier
//tipo (usa genéricos<T>). Muestra la matriz parámetro teniendo como cabeceras de
//filas el número de fila (empezando en 1) y como cabecera de columna una letra
//Unicode empezando en la A. Debe quedar todo bien alineado. Usa 5 para ancho de
//columna.

//Dentro de otra clase, en el programa principal, crea un objeto tipo
//GestorMatriz denominado gm llamando al constructor vacío y haz un menú con las
//siguientes opciones usando las funciones realizadas:
//1.Mostrar tabla.
//2.Mostrar medias: Muestras las medias de filas y de columnas usando dos
//decimales para mostrar las medias. Debe quedar bien claro que es cada cosa
//que se muestra en pantalla.
//3. Mostrar suma de una fila que se le pide al usuario. Indica si hay error.
//4. Mostrar suma de una columna que se le pide al usuario. Indica si hay
//error.
//5. Incremento aleatorio: Crea una array que tenga un n.º aleatorio real
//entre 1 y 10 en todas sus posiciones y del mismo tamaño que la matriz de
//gm. Llama a SumaMatriz pasando dicho array. Muestra ambas matrices y la
//matriz resultado para ver que todo es correcto.
//6. Cambiar Matriz: Pide n.º de filas y n.º de columnas y crea un nuevo objeto
//que asigna a gm y trabajar con él.
//7. Salir. No debe salir hasta que se seleccione esta opción.