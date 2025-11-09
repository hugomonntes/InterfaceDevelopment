using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX4_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnAñadir;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string textToAdd = textBox1.Text.Trim();
            if (textToAdd != null && textToAdd != "" && !listBox1.Items.Contains(textToAdd))
            {
                listBox1.Items.Add(textToAdd);
            } else if (textToAdd != null && textToAdd != "" && !listBox2.Items.Contains(textToAdd))
            {
                listBox2.Items.Add(textToAdd);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (EliminarList1.Checked && listBox1.Items.Count > 0)
            {
                //btnQuitar.Text = "Eliminar de 1";
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (EliminarList2.Checked && listBox2.Items.Count > 0)
            {
                //btnQuitar.Text = "Eliminar de 2";
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }

        }

        private void EliminarList1_CheckedChanged(object sender, EventArgs e)
        {
            if (EliminarList1.Checked)
            {
                btnQuitar.Text = "Eliminar de 1";
            } else if (EliminarList2.Checked)
            {
                btnQuitar.Text = "Eliminar de 2";
            }
        }
    }
}
