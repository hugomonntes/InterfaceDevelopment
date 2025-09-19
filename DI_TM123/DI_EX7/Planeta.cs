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

        public Planeta(bool gaseoso, int satelites) : base()
        {
            this.gaseoso = gaseoso;
            this.satelites = satelites;
        }

        public Planeta() : base("", 1)
        {
            gaseoso = false;
            satelites = 0;
        }

    }
}
