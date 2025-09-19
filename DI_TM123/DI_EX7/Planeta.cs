using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX7
{
    internal class Planeta : Astro
    {
        private bool gaseoso { set; get; }

        public int satelites
        {
            set
            {
                satelites = value > 0 ? value : 0;
            }

            get
            {
                return satelites;
            }
        }

        //        Tendrá dos constructores, uno inicializará todas las propiedades a
        //parámetros.Inicializa lo que se pueda llamando al constructor de Astro.
        //• El otro constructor sin parámetros que inicializa a “” nombre, 1 radio y false
        //la propiedad gaseoso llamando al primer constructor.Cantidad de satélites a
        //0.

        public Planeta(bool gaseoso, int satelites)
        {
            this.gaseoso = gaseoso;
            this.satelites = satelites;
        }

        public Planeta()
        {
            this.gaseoso = true;
        }

    }
}
