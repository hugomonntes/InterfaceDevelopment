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
    public enum eTipo
    {
        Numerico, Textual
    }
    public partial class ValidateTextBox : UserControl
    {
        public ValidateTextBox()
        {
            InitializeComponent();
            textBox1.Location = new System.Drawing.Point(10, 10);
        }

        public ValidateTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        [Category("Mis Propiedades")]
        [Description("Texto del textbox")]
        public string Texto
        {
            set
            {
                textBox1.Text = value;
                Refresh();
            }

            get { return textBox1.Text; }
        }

        [Category("Mis Propiedades")]
        [Description("Multilinea del textbox")]
        public bool Multilinea
        {
            set
            {
                {
                    textBox1.Multiline = value;
                    Refresh();
                }
            }
            get { return textBox1.Multiline; }
        }

        private eTipo tipo;
        [Category("Mis Propiedades")]
        [Description("Tipo de caracter de entrada")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                Refresh();
            }
            get { return tipo; }
        }

        [Category("Eventos Propios")]
        [Description("Cambio de texto")]
        public event EventHandler txb1_TextChanged;
        protected virtual void Ontxb1_TextChanged(object sender, EventArgs e)
        {
            if (txb1_TextChanged != null)
            {
                txb1_TextChanged(this, e);
            }
        }

        private void ValidateTextBox_Load(object sender, EventArgs e)
        {

        }

        bool isChecked = false;

        public bool checkFormatTextual(string content)
        {
            foreach (char c in content)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return content != "";
        }

        public bool checkFormatNumerico(string content)
        {
            return int.TryParse(content.Trim(), out _);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tipo == eTipo.Numerico && checkFormatNumerico(textBox1.Text))
            {
                isChecked = true;
            }
            else if (tipo == eTipo.Textual && checkFormatTextual(textBox1.Text))
            {
                isChecked = true;
            }
            else
            {
                isChecked = false;
            }
            Ontxb1_TextChanged(sender, e);
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Red);
            int w = Width - 10;
            int h = Height - 10;
            if (isChecked)
            {
                pen = new Pen(Color.Green);
            }
            graphics.DrawRectangle(pen, new Rectangle(5, 5, w, h));
        }
    }
}
