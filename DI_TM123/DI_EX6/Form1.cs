using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Realizar un pequeño programa en Windows Forms que mediante un TextBox pida un
        //texto al usuario. Tras eso, el usuario deberá pulsar un botón y se le preguntará
        //mediante una MessageBox con Icono de Pregunta si el usuario desea poner ese
        //texto como título del formulario principal y si contesta que sí, cambiar dicho título
        //(Text = titulo).El texto introducido debe repetirse en la MessageBox como parte del
        //mensaje(concatenación).


        private void button1_Click(object sender, EventArgs e)
        {
            String textFieldContent = txbDatos.Text.Trim();
            if (textFieldContent.Equals("") || textFieldContent == null)
            {
                throw new ArgumentException();
            }

            DialogResult option =  MessageBox.Show(String.Format("Quieres poner {0} como título del documento?", textFieldContent), textFieldContent, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(option == DialogResult.Yes)
            {
                this.Text = textFieldContent;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
