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
            for (int i = listBox1.SelectedItems.Count - 1; i > 0; i--)
            {
                for (int j = frikis.Count - 1; j > 0; j--)
                {
                    if (listBox1.SelectedItems[i].ToString() == frikis[j].Nombre)
                    {
                        frikis.RemoveAt(j);
                    }
                }
            }
            listBox1.SelectedIndices.Clear();
        }
    }
}
