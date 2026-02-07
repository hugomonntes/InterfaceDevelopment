using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosProgramas
{
    public partial class DibujoAhorcado : Control
    {
        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        public DibujoAhorcado(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        [Category("Props Personalizadas")]
        [Description("Número de errores en el juego")]
        private int errores;
        public int Errores
        {
            get
            {
                return errores;
            }
            set
            {
                if (value < 0)
                {
                    errores = 0;
                } else if (value > 7)
                {
                    errores = 7;
                } else
                {
                    errores = value;
                }
            }
        }

        [Category("Nuevos")]
        [Description("Se lanza cada vez que cambia el número de errores")]
        public event EventHandler CambiaError;
        protected virtual void OnCambiaError(EventArgs e)
        {
            if (CambiaError != null)
            {
                CambiaError(this, e);
            }
        }

        [Category("Nuevos")]
        [Description("Se lanza cuando se completa el dibujo")]
        public event EventHandler Ahorcado;
        protected virtual void OnAhoracado(EventArgs e)
        {
            if (Ahorcado != null)
            {
                Ahorcado(this, e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 10;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            switch (errores)
            {
                case 1:
                    g.DrawLine(new Pen(Color.Black), new Point(100, 100), new Point(120, 100));
                    break;
                case 2:
                    g.DrawLine(new Pen(Color.Black), new Point(110, 70), new Point(110, 70));
                    break;
            }
        }
    }
}
