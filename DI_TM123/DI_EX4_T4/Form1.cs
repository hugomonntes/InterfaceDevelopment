using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DI_EX4_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnAñadir;
            timer1.Start();
            this.Text = "";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string textToAdd = textBox1.Text.Trim();
            if (textToAdd != null && textToAdd != "" && !listBox1.Items.Contains(textToAdd))
            {
                listBox1.Items.Add(textToAdd);
                label1.Text = listBox1.Items.Count.ToString();
            }
        }

        public void removeFromList(ListBox lb, RadioButton rb)
        {
            if (rb.Checked && lb.Items.Count > 0)
            {
                try // Creo que puedo optimizarlo con un if comparando psociion a -1 (igual es mas eficiente)
                {
                    lb.Items.RemoveAt(lb.SelectedIndex);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Selecciona algún item para elimniar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            removeFromList(listBox1, EliminarList1);
            removeFromList(listBox2, EliminarList2);
        }

        private void EliminarList1_CheckedChanged(object sender, EventArgs e)
        {
            if (EliminarList1.Checked)
            {
                btnQuitar.Text = "Eliminar de 1";
            }
            else if (EliminarList2.Checked)
            {
                btnQuitar.Text = "Eliminar de 2";
            }
        }
        public void traspasarListas(ListBox origen, ListBox destino, RadioButton rb)
        {
            if (rb.Checked && origen.Items.Count > 0)
            {
                foreach (var item in origen.Items)
                {
                    destino.Items.Add(item);
                }
                origen.Items.Clear();
            }
        }
        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            traspasarListas(listBox1, listBox2, rbIntercambio1);
            traspasarListas(listBox2, listBox1, rbIntercambio2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedIndices.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            eachChar("abcdefghi");
            //this.Text += ;
        }

        public void eachChar(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                this.Text += word[i];
            }
        }

        //private void toolTip_Popup(object sender, PopupEventArgs e)
        //{
        //    TextBox txb = (TextBox)sender;
        //    if (txb.Name == "textBox1")
        //    {
        //        ToolTip a = new ToolTip();
        //        a.ToolTipTitle = listBox1.Items.Count.ToString();
        //    }
        //}
    }
}

//El título del formulario debe ser animado, apareciendo una letra del
//título empezando por el final (efecto scroll) cada 200 ms y cuando se
//complete, volviendo a empezar. Además debe cambiar también el icono
//del formulario. Se debe hacer sólo con un timer.

//Meter ToolTip para los botones. También para la lista secundaria, en este
//caso el ToolTip debe mostrar la cantidad de elementos que hay en esta
//lista.