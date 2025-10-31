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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            Modal modal = new Modal();
            modal.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            modal.BackgroundImageLayout = ImageLayout.Stretch;
            modal.Show();
        }
    }
}
