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
                    this.Refresh();
                }
                else if (value > 7)
                {
                    errores = 7;
                    this.Refresh();
                }
                else
                {
                    errores = value;
                    this.Refresh();
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
        protected virtual void OnAhorcado(EventArgs e)
        {
            if (Ahorcado != null)
            {
                Ahorcado(this, e);
            }
        }

        protected override void OnPaint(PaintEventArgs e) // TODO arreglar pintar
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 10;
            int w = Width;
            int h = Height;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Black,grosor))
            {
                switch (errores)
                {
                    case 7:
                        g.DrawLine(pen, w / 2, 120, w / 2 - 20, 160);
                        g.DrawLine(pen, w / 2, 120, w / 2 + 20, 160);
                        goto case 6;
                    case 6:
                        g.DrawLine(pen, w / 2, 70, w / 2, 120);
                        goto case 5;
                    case 5:
                        g.DrawEllipse(pen, w / 2 - 15, 40, 30, 30);
                        goto case 4;
                    case 4:
                        g.DrawLine(pen, w / 2, 20, w / 2, 40);
                        goto case 3;
                    case 3:
                        g.DrawLine(pen, w / 3, 20, w / 2, 20);
                        goto case 2;
                    case 2:
                        g.DrawLine(pen, w / 3, h - 20, w / 3, 20);
                        goto case 1;
                    case 1:
                        g.DrawLine(pen, w / 4, h - 20, w / 2, h - 20);
                        break;
                }
            }
        }
    }
}
