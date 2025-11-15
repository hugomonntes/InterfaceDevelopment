using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX_1EVAL
{
    internal class Record
    {
        private string nombre;
        private int edad;
        private int puntuacion;

        public string Nombre { get; set; }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Introduce una edad válida");
                }
                edad = value;
            }
        }
        public int Puntuacion { get; set; }

        public Record(string nombre, int edad, int puntuacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.puntuacion = puntuacion;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Edad: {edad}, Puntuacion: {puntuacion}";
        }
    }
}
