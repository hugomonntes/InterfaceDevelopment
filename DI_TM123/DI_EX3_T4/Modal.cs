using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX3_T4
{
    public partial class Modal : Form
    {
        public Modal(string path)
        {
            InitializeComponent();
            this.Text = path;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pbModal.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pbModal.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
