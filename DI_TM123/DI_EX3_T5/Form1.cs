using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DI_EX3_T5
{
    public partial class Form1 : Form
    {
        private string[] archivos;
        private int indiceActual = 0;
        private Timer timerPresentacion = new Timer();

        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 2;
            timerPresentacion.Tick += TimerPresentacion_Tick;
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
                        MessageBox.Show("No se encontraron imágenes en la carpeta.");
                    }
                }
                timerPresentacion.Start();
            }
        }

        private void TimerPresentacion_Tick(object sender, EventArgs e)
        {
            indiceActual = (indiceActual + 1) % archivos.Length;
            MostrarImagen();

            reproductorMultimedia1.Segundos++;
        }

        private void MostrarImagen()
        {
            if (indiceActual < archivos.Length)
            {
                pictureBox1.ImageLocation = archivos[indiceActual];
                timerPresentacion.Interval = (comboBox1.SelectedIndex + 1) * 100;
            }
        }

        private void reproductorMultimedia1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductorMultimedia1.Minutos++;
        }
    }
}