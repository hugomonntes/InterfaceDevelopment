using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX7
{
    public class Planeta : Astro , ITerraformable
    {
        private bool gaseoso;
        private bool satelites;

        private bool Gaseoso { set; get; }

        public int Satelites
        {
            set
            {
                Satelites = value > 0 ? value : 0;
            }

            get
            {
                return Satelites;
            }
        }

        public Planeta(string nombre, int radio, bool gaseoso, int satelites) : base(nombre, radio)
        {
            this.Gaseoso = gaseoso;
            this.Satelites = satelites;
        }

        public Planeta() : this("", 1, false, 0)
        {
        }

        bool ITerraformable.esHabitable()
        {
            return !Gaseoso && (Radio >= 2000 && Radio <= 8000);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0,-10}, Satelites: {1,4}, Radio: {2,8:F2}", Nombre, Satelites, Radio);
        }
    }
}
