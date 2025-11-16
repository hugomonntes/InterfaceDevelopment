using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX_1EVAL
{
    public partial class FrmDatos : Form
    {
        public void initCombo()
        {
            for (int i = 18; i <= 100; i++)
            {
                comboBox1.Items.Add(i);
            }
        }
        public FrmDatos()
        {
            InitializeComponent();
            initCombo();
        }
    }
}
