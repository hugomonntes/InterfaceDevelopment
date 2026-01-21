using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosProgramas
{
    public enum EMarca
    {
        NADA, CIRCULO, CRUZ, IMAGEN
    }
    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        private Color colorSkyBlue = Color.SkyBlue;
        private Color colorPink = Color.Pink;

        private bool gradient = false;
        [Category("Appearance")]
        [Description("Indica si hay gradiente")]
        public bool Gradient
        {
            set { gradient = value; this.Refresh(); }
            get { return gradient; }
        }

        private Image imagenMarca;
        [Category("Appearance")]
        [Description("Escoger Imagen")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                Size = new Size(30, 30);
                this.Refresh();
            }
            get
            {
                return imagenMarca;
            }
        }

        private EMarca marca = EMarca.NADA;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        [Category("Appearance")]
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo

            if (gradient)
            {
                LinearGradientBrush gradientBrush = new LinearGradientBrush(new Point(100, 100), new Point(100, 0), colorSkyBlue, colorPink);
                g.FillRectangle(gradientBrush, new Rectangle(new Point(0), new Size(1000, 100)));
            }

            switch (Marca)
            {
                case EMarca.CIRCULO:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case EMarca.CRUZ:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case EMarca.IMAGEN:
                    if (EMarca.IMAGEN != null)
                    {
                        g.DrawImage(ImagenMarca, h / 2, h / 2, h * 2, h * 2);
                        offsetX = h * 3;
                        offsetY = h;
                    }
                    else
                    {
                        EMarca marca = EMarca.NADA;
                    }
                    break;
            }


            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();

        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
    }
}
