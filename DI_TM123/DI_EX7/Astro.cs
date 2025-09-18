using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX7
{
    internal class Astro
    {
        private String nombre;
        private double radio;

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
    }
}
