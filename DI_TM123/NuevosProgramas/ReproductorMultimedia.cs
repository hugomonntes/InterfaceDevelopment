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

        [Category("Play")]
        [Description("Cambiar texto boton")]
        public event EventHandler PlayClick;
        protected virtual void OnPlayClick(object sender, EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, EventArgs.Empty);
            }
        }

        [Category("Props Label")]
        [Description("Minutos formato label")]
        private int minutos;
        public int Minutos
        {
            set
            {
                if (value > 59)
                {
                    minutos = 0;
                }
                else if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    minutos = value;
                }
                label1.Text = $"{minutos:00}:{segundos:00}";
            }
            get { return minutos; }
        }

        [Category("Props label")]
        [Description("Segundos formato label")]
        private int segundos;
        public int Segundos
        {
            set
            {
                if (value > 59)
                {
                    OnDesbordaTiempo(this, EventArgs.Empty);
                    segundos = value % 60;
                }
                else if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    segundos = value;
                }
                label1.Text = $"{minutos:00}:{segundos:00}";
            }
            get { return segundos; }
        }

        [Category("Event")]
        [Description("Maximo de tiempo superado")]
        public event EventHandler DesbordaTiempo;
        protected virtual void OnDesbordaTiempo(object sender, EventArgs e)
        {
            if (DesbordaTiempo != null)
            {
                DesbordaTiempo(this, EventArgs.Empty);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text == "Play" ? "Stop" : "Play";
            OnPlayClick(this, EventArgs.Empty);
        }
    }
}