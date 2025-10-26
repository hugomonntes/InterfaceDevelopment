using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (validateTextBoxsColor(((TextBox)sender).Text).Item1) 
            { 
                ((TextBox)sender).ForeColor = Color.Green;
            }
            else
            {
                ((TextBox)sender).ForeColor = Color.Red;
            }
        }

        public static (bool, byte) validateTextBoxsColor(string text)
        {
            bool isChecked = byte.TryParse(text.Trim(), out byte value);
            return (isChecked, value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] textBoxes = { textBox1.Text, textBox2.Text, textBox3.Text};

            foreach (string txb in textBoxes)
            {
                if (validateTextBoxsColor(txb).Item1)
                {
                    byte r = validateTextBoxsColor(txb).Item2;
                    byte g = validateTextBoxsColor(txb).Item2;
                    byte b =  validateTextBoxsColor(txb).Item2;

                    this.BackColor = Color.FromArgb(r, g, b);
                }
                else
                {
                    MessageBox.Show("Introduce números del 0 al 255 en todos los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                                          
        }

        // Utilizar formClosing
    }
}
