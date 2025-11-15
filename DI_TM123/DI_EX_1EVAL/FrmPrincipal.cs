using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX_1EVAL
{
    public partial class FrmPrincipal : Form
    {
        int counterCbMarcados = 0;
        public void initCheckBoxes(int numeroDeCheckBoxes)
        {
            ToolTip tooltip = new ToolTip();
            int x = 30;
            int y = 30;
            for (int i = 0; i < numeroDeCheckBoxes; i++)
            {
                CheckBox newCb = new CheckBox();
                newCb.Text = $"{i + 1}";
                newCb.Height = 30;
                newCb.Width = 45;
                newCb.Left = x;
                newCb.Top = y;
                x += 45;
                if (i % 6 == 5)
                {
                    x = 30;
                    y += 40;
                }
                newCb.CheckedChanged += (sender, e) =>
                {
                    if (newCb.Checked)
                    {
                        tooltip.SetToolTip(newCb, "Activado");
                        counterCbMarcados++;
                    }
                    else
                    {
                        tooltip.SetToolTip(newCb, "Desactivado");
                        counterCbMarcados--;
                    }
                };
                this.Controls.Add(newCb);
            }
        }

        public void animacionColorBotones(Button[] btns)
        {
            Timer tm = new Timer();
            tm.Interval = 300;
            tm.Start();

            int i = 0;
            tm.Tick += (sender, e) =>
            {
                if (btns[i].BackColor == Color.Beige)
                {
                    btns[i].BackColor = Color.Yellow;
                }
                else
                {
                    btns[i].BackColor = Color.Beige;
                }


                i++;
                if (i >= btns.Length)
                {
                    i = 0;
                }
            };
        }
        public FrmPrincipal()
        {
            InitializeComponent();
            initCheckBoxes(49);
            Button[] btns = { btnJugar, btnReset, btnSalir };
            animacionColorBotones(btns);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                    cb.BackColor = Color.Empty;
                }

                if (ctrl is TextBox txb)
                {
                    txb.Text = "Resultado";
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (LstNombres.Items.Count > 0)
            {
                if (MessageBox.Show("Quieres salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LstNombres.Items.Count > 0)
            {
                if (MessageBox.Show("Quieres salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (counterCbMarcados != 6)
            {
                MessageBox.Show("Error no has seleccionado 6 numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Random r = new Random();
        public List<int> almacenarNumerosAleatorios(List<int> listaNumerosAleatorios)
        {
            listaNumerosAleatorios.Add(r.Next(1,49));
            return listaNumerosAleatorios;
        }
    }
}
