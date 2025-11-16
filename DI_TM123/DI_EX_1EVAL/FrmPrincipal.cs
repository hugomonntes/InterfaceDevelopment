using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX_1EVAL
{
    public partial class FrmPrincipal : Form
    {
        List<int> numerosPremiados = new List<int>();
        List<int> cbMarcados = new List<int>();
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
                int.TryParse(newCb.Text, out int number);
                newCb.CheckedChanged += (sender, e) =>
                {
                    if (newCb.Checked)
                    {
                        tooltip.SetToolTip(newCb, "Activado");
                        counterCbMarcados++;
                        cbMarcados.Add(number);
                    }
                    else
                    {
                        tooltip.SetToolTip(newCb, "Desactivado");
                        counterCbMarcados--;
                        cbMarcados.Remove(number);
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

                if (ctrl is Label lbl)
                {
                    lbl.Text = "Resultado";
                }
            }
            numerosPremiados.Clear();
            cbMarcados.Clear();
            counterCbMarcados = 0;
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
            else
            {
                while (numerosPremiados.Count != 6)
                {
                    almacenarNumerosAleatorios(numerosPremiados);
                }
                foreach (int item in numerosPremiados)
                {
                    LblResultados.Text += $" {item} ";
                }
                pintarContarNumerosPremiados();
                lanzarFormModal();
            }
        }

        Random r = new Random();
        public void almacenarNumerosAleatorios(List<int> listaNumerosAleatorios)
        {
            int numero = r.Next(1, 49);
            if (!listaNumerosAleatorios.Contains(numero))
            {
                listaNumerosAleatorios.Add(numero);
            }
        }
        private int pintarContarNumerosPremiados()
        {
            int contadorAcertados = 0;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    int.TryParse(cb.Text, out int number);

                    if (numerosPremiados.Contains(number))
                    {
                        cb.BackColor = Color.Gold;
                        contadorAcertados++;
                    }
                }
            }
            return contadorAcertados;
        }

        private void lanzarFormModal()
        {
            if (pintarContarNumerosPremiados() >= 1)
            {
                FrmDatos frmDatos = new FrmDatos();
                frmDatos.MaximizeBox = false;
                frmDatos.MinimizeBox = true;
                foreach (var item in frmDatos.Controls)
                {
                    if (item is Button btn)
                    {
                        btn.MouseEnter += (sender, e) =>
                        {
                            btn.BackColor = Color.Blue;
                        };

                        btn.MouseLeave += (sender, e) =>
                        {
                            btn.BackColor = Color.Empty;
                        };

                        if (btn.Name is "btnCancelar")
                        {
                            btn.Click += btnReset_Click;
                            this.Close();
                        }
                        else
                        {
                            string nombre = "";
                            int edad = 0;
                            btn.Click += btnReset_Click;
                            foreach (var ctrl in frmDatos.Controls)
                            {
                                if (ctrl is TextBox txb && txb.Text != "" && txb.Text != null)
                                {
                                    nombre = txb.Text;
                                }
                                else
                                {
                                    MessageBox.Show("Introduce un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                if (ctrl is ComboBox cbEdad)
                                {
                                    edad = (int)cbEdad.SelectedItem;
                                }

                            }
                            Record r = new Record(nombre, edad, pintarContarNumerosPremiados());
                        }
                    }
                }
                frmDatos.ShowDialog();
            }
        }
    }
}
