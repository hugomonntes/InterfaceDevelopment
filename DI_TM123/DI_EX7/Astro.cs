using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX7
{
    internal class Astro
    {
        private String nombre
        {
            set
            {
                nombre = String.Format("\"\"",value.ToUpper());
            }

            get
            {
                return nombre;
            }
        }

        private double radio
        {
            set
            {
                radio = radio > 0 ? radio : throw new ArgumentException();
            }

            get
            {
                return radio;
            }
        }

        public Astro()
        {
            nombre = "Tierra";
            radio = 6378;
        }

        public Astro(String nombre, double radio)
        {
            this.nombre = nombre;
            this.radio = radio;
        }

        public override bool Equals(object? obj)
        {
            return ((Astro)obj).nombre == nombre || ((string)obj) == nombre;
        }
        
    }
}
