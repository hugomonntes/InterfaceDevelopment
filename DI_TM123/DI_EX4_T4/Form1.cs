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
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(EliminarList1.Checked && listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
