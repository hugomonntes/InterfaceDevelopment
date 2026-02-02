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
    public partial class ReproductorMultimedia : UserControl
    {
        public ReproductorMultimedia()
        {
            InitializeComponent();
        }

        public ReproductorMultimedia(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text == "Play" ? "Stop" : "Play";
            OnPlayClick(sender, e);
        }

        [Category("Play")]
        [Description("Cambia el texto del boton")]
        public event EventHandler PlayClick;
        protected virtual void OnPlayClick(object sender, EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, EventArgs.Empty);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
