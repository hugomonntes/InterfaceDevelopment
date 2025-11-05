using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX3_T4
{
    public partial class Main : Form // TODO Titulo al inicio. formato 00:00. Gestionar cancel en OpenFile. Ajuste sin deformación. Todos los archivos. Revisar filtro. Imagen corrupta. Revisar constructor secundario msin bucle
    {
        Modal modal;
        int segundos = 0;
        int minutos = 0;
        public Main()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void newImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            String[] pathSplited = openFileDialog.FileName.Split('\\');
            modal = new Modal(pathSplited[pathSplited.Length - 1]);
            changuePictureBoxModal(modal, openFileDialog.FileName);
            if (cbModal.Checked)
            {
                modal.ShowDialog();
            } else
            {
                modal.Show();
            }
        }

        public void changuePictureBoxModal(Form modal,string fileName)
        {
            foreach (Control item in modal.Controls)
            {
                if (item is PictureBox ptb && ptb.Name == "pbModal")
                {
                    ptb.Image = Image.FromFile(fileName);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if(segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            this.Text = $"Visor de imágenes {minutos}:{segundos}";
        }

        private void cbModal_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderCasted = ((CheckBox)sender);
            if (senderCasted.Checked)
            {
                senderCasted.ForeColor = Color.Red;
            } else
            {
                senderCasted.ForeColor = Color.Black;
            }
        }
    }
}

//Se desea realizar un visor de imágenes simple. Para ello en el formulario
//principal se dispone de un botón “Nueva Imagen” que, al ser pulsado, sale un
//componente OpenFileDialog (Ver Apéndice III) en el que se verán diversos
//archivos de imagen (al menos jpg y png) además del filtro “todos los
//archivos”.
//Debe haber también un checkbox con la palabra Modal como texto.
//Una vez que el usuario seleccione una imagen y le de Aceptar en el
//OpenFileDialog se deben hacer las siguientes tareas:

//• Se saca un segundo formulario en el que quepa la imagen entera y
//ocupándolo todo. Si cambias el tamaño del formulario debe cambiar
//también el de la imagen de fondo deformándose (Usa un picturebox). (ok)

//• El formulario secundario será modal si el checkbox está marcado y no
//modal en caso contrario.(ok)

//• Habrá en el PictureBox del secundario un menú contextual para elegir si
//la imagen se ajusta perfectamente al PictureBox o lo hace sin
//deformarse.(ok)

//• El título del formulario principal será “Visor de imágenes“ y a
//continuación el tiempo de uso en minutos y segundos (formato siempre
//con dos cifras mm:ss).(ok)

//• El título del formulario secundario será el nombre de la imagen (sin el
//path).

//• Al marcar el Checkbox además se pone la palabra Modal en Rojo. Si se
//desmarca vuelve a ponerla en negro.
