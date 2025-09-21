using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX7
{
    public class Astro
    {
        private string nombre;
        private double radio;

        public string Nombre
        {
            get 
            { 
                return nombre; 
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

        public Astro()
        {
            Nombre = "Tierra";
            Radio = 6378;
        }

        public Astro(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public override bool Equals(object? obj) 
        { 
            return ((Astro)obj).Nombre == Nombre || ((string)obj) == Nombre; 
        }
    }
}
