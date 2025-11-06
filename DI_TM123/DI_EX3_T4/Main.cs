using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX3_T4
{
    public partial class Main : Form // TODO Titulo al inicio(ok). formato 00:00(ok). Gestionar cancel en OpenFile(ok). Ajuste sin deformación(ok). Todos los archivos(ok). Revisar filtro(ok). Imagen corrupta(ok). Revisar constructor secundario sin bucle(ok)
    {
        int segundos = 0;
        int minutos = 0;
        string nombreArchivo;
        public Main()
        {
            InitializeComponent();
            timer1.Start();
            this.Text = "Visor de imágenes 00:00";
        }

        private void newImage_Click(object sender, EventArgs e)
        {
            string path = "";
            DialogResult openFile = openFileDialog.ShowDialog();
            if (openFile == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                nombreArchivo = Path.GetFileName(path); // Si curro no me deja lo hago con el split
            }
            try
            {
                Modal modal = new Modal();
                modal.Text = nombreArchivo;
                modal.cargarImagen(path);

                if (cbModal.Checked)
                {
                    modal.ShowDialog();
                }
                else
                {
                    modal.Show();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("La imagen no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                // No aviso de nada ya que el user quiere salir (Preguntrar curro que informar o no en este caso)
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            this.Text = $"Visor de imágenes {minutos:D2}:{segundos:D2}";
        }

        private void cbModal_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderCasted = ((CheckBox)sender);
            if (senderCasted.Checked)
            {
                senderCasted.ForeColor = Color.Red;
            }
            else
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
