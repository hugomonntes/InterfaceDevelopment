using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX5_T5_
{
    public partial class Form1 : Form
    {
        private List<sFriki> frikis = new List<sFriki>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i > 0; i--)
            {
                for (int j = frikis.Count - 1; j >= 0; j--)
                {
                    if (listBox1.SelectedItems[i].ToString() == frikis[j].Nombre)
                    {
                        frikis.RemoveAt(j);
                    }
                }
            }
            listBox1.SelectedIndices.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            DialogResult a = form.ShowDialog();
            if (a == DialogResult.OK)
            {
                string nombre = form.validateTextBox1.Texto;
                int edad = int.Parse(form.validateTextBox2.Texto);
                bool aficionChecked = Enum.TryParse(form.comboBox1.SelectedItem.ToString(), out eAficion aficion);
                bool sexoooChecked = Enum.TryParse(form.radioButton1.Checked ? form.radioButton1.ToString() : form.radioButton2.ToString(), out eSexo sexoo);
                bool sexoChecked = Enum.TryParse(form.radioButton3.Checked ? form.radioButton3.ToString() : form.radioButton4.ToString(), out eSexo sexo);
                string foto = form.textBox1.Text;
                sFriki friki = new sFriki(nombre, edad, aficion, sexoo, sexo, foto);
                frikis.Add(friki);
                listBox1.Items.Add(friki.Nombre);
            }
        }
    }
}
