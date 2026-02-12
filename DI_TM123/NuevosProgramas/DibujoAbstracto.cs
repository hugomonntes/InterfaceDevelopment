using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosProgramas
{
    public enum Figuras
    {
        Rectangulo, Circulo, Triangulo, Linea
    }

    public partial class DibujoAbstracto : UserControl
    {
        public DibujoAbstracto()
        {
            InitializeComponent();
        }

        public DibujoAbstracto(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string Figura
        {
            set
            {
                if (value == Figuras.Linea.ToString())
                {
                    value = Figuras.Linea.ToString();
                }
            }
        }
    }
}
