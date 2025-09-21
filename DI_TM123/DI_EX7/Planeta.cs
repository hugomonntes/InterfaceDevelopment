using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX7
{
    internal class Planeta : Astro , ITerraformable
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

        public Planeta(string nombre, int radio, bool gaseoso, int satelites) : base(nombre, radio)
        {
            this.gaseoso = gaseoso;
            this.satelites = satelites;
        }

        public Planeta() : this("", 1, false, 0)
        {
        }

        bool ITerraformable.esHabitable()
        {
            return !gaseoso && (radio >= 2000 && radio <= 8000);
        }

//        Sobreescribe ToString de forma que devuelva la propiedad Nombre ocupando
//10 caracteres, la cantidad de satélites ocupando 4 caracteres y el radio con 2
//decimales(usa string.Format que funciona como Console.Write pero devuelve
//en vez de mostrar).


        public override string ToString()
        {
            return string.Format("{0.10}", getNombre());
        }
    }
}
