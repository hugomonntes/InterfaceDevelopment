using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX7
{
    abstract class Astro//TODO abstracta
    {
        private string nombre;
        private double radio;

        public string Nombre
        {
            get 
            { 
                return string.Format($"\"{nombre}\""); //TODO entre ""
            }
            set 
            { 
                nombre = value.ToUpper(); 
            }
        }

        public double Radio
        {
            get 
            { 
                return radio; 
            }
            set
            {
                radio = value > 0 ? value : throw new ArgumentException();
            }
        }

        public Astro() : this("Tierra", 6378)//TODO llamar al otro ctor
        {
        }

        public Astro(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Astro astro) { 
                return Nombre == astro.Nombre;
            }

            if (obj is string nombreStr) 
            {
                return Nombre == nombreStr.ToUpper();
            }

            return false;
        }
    }
}
