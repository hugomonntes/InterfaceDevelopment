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
        Modal modal;

        public Main()
        {
            InitializeComponent();
        }

        private void newImage_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            modal = new Modal();
            modal.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            modal.BackgroundImageLayout = ImageLayout.Stretch;
            if (cbModal.Checked)
            {
                modal.ShowDialog();
            } else
            {
                modal.Show();
            }
        }
    }
}
