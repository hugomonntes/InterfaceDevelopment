using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX2_T4
{
    public partial class Form1 : Form//Etiquetas informativas(ok). ESC (OK). No preguntar dos veces si se pulsa exit(ok). Mensaje error solo 1 vez(OK). Cambio color si error(OK). Gestionas bien accept button(ok). Excepcion imagen(OK). No permitas cambio de tamaño form(ok). Complertar reset(OK).
    {
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = btnExit;
            this.AcceptButton = btnColor;
            this.ShowInTaskbar = false;
            Color orginalColor = this.BackColor;
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
            string[] textBoxes = { textBox1.Text, textBox2.Text, textBox3.Text };

            foreach (string txb in textBoxes)
            {
                if (validateTextBoxsColor(txb).Item1)
                {
                    byte r = validateTextBoxsColor(txb).Item2;
                    byte g = validateTextBoxsColor(txb).Item2;
                    byte b = validateTextBoxsColor(txb).Item2;

                    this.BackColor = Color.FromArgb(r, g, b);
                }
                else
                {
                    MessageBox.Show("Introduce números del 0 al 255 en todos los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(MessageBox.Show("Seguro que qieres salir del progrma?", "Salir de la aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                e.Cancel = true;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == null || textBox4.Text.Trim() == "")
            {
                MessageBox.Show($"Introduce una ruta absoluta con la imagen en el textBox", "Error en la imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    pictureBox.Image = new Bitmap(textBox4.Text);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"No se encuentra la imagen {pictureBox}", "Error en la imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            this.BackColor = Color.Empty;
            pictureBox.Image = null;
        }

        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += buttons_MouseEnter;
                    btn.MouseLeave += buttons_MouseLeave;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
