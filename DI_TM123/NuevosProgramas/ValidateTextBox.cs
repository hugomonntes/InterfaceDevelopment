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
            this.Size = new System.Drawing.Size(textBox1.Width + 20, textBox1.Height + 20);
            textBox1.Size = new System.Drawing.Size(this.Width - 20, this.Height - 20);
        }

        public ValidateTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private string texto;
        [Category("Mis Propiedades")]
        [Description("Texto del textbox")]
        public string Texto { get; set; }

        private bool multilinea;
        [Category("Mis Propiedades")]
        [Description("Multilinea del textbox")]
        public bool Multilinea
        {
            set
            {
                this.multilinea = value;
            }

            get { return this.multilinea; }
        }
        private void ValidateTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
