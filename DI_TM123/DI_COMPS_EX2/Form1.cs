using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_COMPS_EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void etiquetaAviso1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CLICK", "CLICK", MessageBoxButtons.OK);
        }
    }
}
