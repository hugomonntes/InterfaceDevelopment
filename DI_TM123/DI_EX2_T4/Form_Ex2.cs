using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX2_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = button1;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar el programa?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(Byte.TryParse(textBox1.Text, out Byte rgbTx1))
            {
                textBox1.ForeColor = Color.Red;
            };
        }
    }
}
