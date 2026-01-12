using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Circulo
    }
    public partial class EtiquetaAviso : Control
    {   
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        private EMarca marca = EMarca.Nada;
        [Category("Appearance")]

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;
            SolidBrush solidBrush = new SolidBrush(this.ForeColor);
            graphics.DrawString(this.Text, this.Font, solidBrush, 0, 0); 
            this.Size = graphics.MeasureString(this.Text, this.Font).ToSize();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
    }
}
