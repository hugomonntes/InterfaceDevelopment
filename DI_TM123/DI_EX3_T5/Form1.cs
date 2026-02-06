using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX3_T5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }

        }

        private void reproductorMultimedia1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductorMultimedia1.Minutos++;
            reproductorMultimedia1.Segundos++;
        }

        Timer timer = new Timer();
        private void reproductorMultimedia1_Click(object sender, EventArgs e)
        {
            timer.Start();
            timer.Interval = 100;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();
            string[] archivos = openFileDialog.FileNames;
            timer.Tick += (sender2, e2) =>
            {
                for (int i = 0; i < archivos.Length; i++)
                {
                    pictureBox1.ImageLocation = archivos[i];
                    if (i >= archivos.Length)
                    {
                        i = 0;
                    }
                }
            };
        }
    }
}
