using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX7
{
    public class Planeta : Astro, ITerraformable
    {

        private bool gaseoso;
        public bool Gaseoso { set; get; }

        private int satelites;
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

        //Sobrecarga los operadores ++ y -- (mira el apéndice I y deduce como
        //hacerlo) de forma que si se aplica a un Planeta, incremente o decremente en
        //una unidad la cantidad de satélites.No debe permitir bajar de 0.
        //Es decir, si se dispone del siguiente código:
        //Planeta p = new Planeta();
        //        p++;
        //Debe funcionar e incrementar el n.º de satélites de p. Análogamente con p--
        //debería de disminuir salvo que ya sea 0.

        public static Planeta operator ++(Planeta p)
        {
            p.Satelites++;
            return p;
        }

        public static Planeta operator --(Planeta p)
        {
            if (p.Satelites > 0) 
            {
                p.Satelites--;
            }
            return p;
        }
    }
}
