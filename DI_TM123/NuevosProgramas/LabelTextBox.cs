using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosProgramas
{
    public enum EPosicion
    {
        IZQUIERDA, DERECHA
    }
    public partial class LabelTextBox : UserControl
    {
        private EPosicion posicion = EPosicion.IZQUIERDA;
        [Category("Nuevas")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public EPosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    OnPosicionChanged(EventArgs.Empty);
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Nuevas")] // O se puede meter en categoría Design.
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Nuevas")] // O se puede meter en categoría Appearance.
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
            }
            get
            {
                return lbl.Text;

            }
        }

        [Category("Nuevas")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        [Category("Nuevas")]
        [Description("Propiedad PasswordChar del Textbox interno")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        void recolocar()
        {
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);
                    // Establecemos posición componente txt
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //Establecemos ancho del Textbox
                    //(la label tiene ancho por autosize)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    lbl.Width = lbl.Width + Separacion; // TODO
                    lbl.BackColor = Color.Red;
                    txt.BackColor = Color.Green;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    //this.Width = Math.Max(lbl.Width + txt.Width, lbl.Width + txt.Width + Separacion);
                    break;
                case EPosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    txt.Width = this.Width - lbl.Width - Separacion;
                    lbl.Width = lbl.Width + Separacion; // TODO
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    lbl.BackColor = Color.Red;
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    this.Width = lbl.Width + txt.Width + Separacion;
                    break;
            }
        }

        public LabelTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
        }

        public event EventHandler PosicionChanged;

        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        public event EventHandler SeparationChanged;
        protected virtual void OnSeparationChanged(EventArgs e)
        {
            if(SeparationChanged != null)
            {
                SeparationChanged(this, e);
            }
        }

        public event EventHandler TxtChanged;
        protected virtual void OnTxtChanged(EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, e);
            }
        }
        private void txt_txtChanged(object sender, EventArgs e)
        {
            this.OnTxtChanged(e);
        }
    }
}
