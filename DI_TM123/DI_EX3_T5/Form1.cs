using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DI_EX3_T5
{
    public partial class Form1 : Form // TODO eee cambiar teimpo rne ejecucion y play sin dir elegido. filtro archivos
    {
        private string[] archivos;
        private int indiceActual = 0;
        private int duracionImagen = 0; // Segundos que dura la imagen en pantalla
        private int contadorSegundosImagen = 0; // Tiempo que lleva la imagen estando en pantalla

        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 2;
        }

        private void btnSeleccionarDirectorio_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    archivos = Directory.GetFiles(fbd.SelectedPath);

                    if (archivos.Length > 0)
                    {
                        indiceActual = 0;
                        MostrarImagen();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron imagenes en la carpeta.");
                    }
                }
            }
        }

        private void TimerPresentacion_Tick(object sender, EventArgs e)
        {
            reproductorMultimedia1.Segundos++;
            contadorSegundosImagen++;
            if (contadorSegundosImagen == duracionImagen)
            {
                indiceActual++;
                if (indiceActual >= archivos.Length) // NULLREFERENCE
                {
                    indiceActual = 0;
                }
                MostrarImagen();
                contadorSegundosImagen = 0;
            }
        }

        private void MostrarImagen()
        {
            if (indiceActual < archivos.Length)
            {
                pictureBox1.ImageLocation = archivos[indiceActual];
                //timerPresentacion.Interval = (comboBox1.SelectedIndex + 1) * 100;
            }
        }

        private void reproductorMultimedia1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductorMultimedia1.Minutos++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            duracionImagen = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void reproductorMultimedia1_PlayClick(object sender, EventArgs e)
        {
            if (timerPresentacion.Enabled)
            {
                timerPresentacion.Stop();
            }
            else
            {
                timerPresentacion.Start();
            }
        }
    }
}