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
        Nada,
        Cruz,
        Circulo,
        Imagen
    }
    public partial class EtiquetaAviso : Control
    {
        private EMarca marca = EMarca.Nada;
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

        private Image imagenMarca = null;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                //Size = new Size(30, 30);
                this.Refresh();
            }
            get
            {

                return imagenMarca;

            }
        }
        private bool fondoGradiente = false;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public bool FondoGradiente
        {
            set
            {
                fondoGradiente = value;
                this.Refresh();
            }
            get
            {
                return fondoGradiente;
            }
        }
        private Color colorInicioGradiente = Color.White;
        [Category("Appearance")]
        [Description("Indica el color inicial del fondo gradiente en caso de tenerlo")]
        public Color ColorInicioGradiente
        {
            set
            {
                colorInicioGradiente = value;
                this.Refresh();
            }
            get
            {
                return colorInicioGradiente;
            }
        }

        private Color colorFinalGradiente = Color.White;
        [Category("Appearance")]
        [Description("Indica el color final del fondo gradiente en caso de tenerlo")]
        public Color ColorFinalGradiente
        {
            set
            {
                colorFinalGradiente = value;
                this.Refresh();
            }
            get
            {
                return colorFinalGradiente;
            }
        }

        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        //Crea un evento denominado ClickEnMarca que será lanzado cuando el usuario
        //pulsa el ratón pero solo en la zona donde está la marca(salvo que sea Nada).

        //private void ClickEnMarca(object sender, MouseEventArgs e)
        //{
        //    OnClickEnMarca(e);
        //} 
        [Category("Acción")]
        [Description("Se lanza cuando se hace clic en la marca")]
        public event EventHandler ClickEnMarca;

        protected virtual void OnClickEnMarca()
        {
            if (ClickEnMarca != null)
            {
                ClickEnMarca(this, EventArgs.Empty);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int x = e.X;
            int y = e.Y;
            if (marca != EMarca.Nada && x <= offsetX)
            {
                OnClickEnMarca();
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
        int offsetX;
        int offsetY;
        int grosor;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            grosor = 0; //Grosor de las líneas de dibujo
            offsetX = 0; //Desplazamiento a la derecha del texto
            offsetY = 0; //Desplazamiento hacia abajo del texto

            // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            if (fondoGradiente)
            {
                LinearGradientBrush l = new LinearGradientBrush(new Point(0, 0), new Point(30, 30), colorInicioGradiente, colorFinalGradiente);
                g.FillRectangle(l, new Rectangle(0, 0, Width, Height));
            }
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case EMarca.Cruz:
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
                case EMarca.Imagen:
                    if (imagenMarca != null)
                    {
                        g.DrawImage(imagenMarca, h / 2, h / 2, h, h);
                        offsetX = h * 2;
                        offsetY = h / 2;
                    }
                    else
                    {
                        marca = EMarca.Nada;
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
    }
}
