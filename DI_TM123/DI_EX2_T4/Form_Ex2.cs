using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX2_T4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = button1;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar el programa?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (validateTextBoxsColor(sender).Item1)
            {
                ((TextBox)sender).ForeColor = Color.Green;
            }
            else
            {
                ((TextBox)sender).ForeColor = Color.Red;
            }
        }

        public static (bool, int) validateTextBoxsColor(object sender)
        {
            return (Byte.TryParse(((TextBox)sender).Text.Trim(), out Byte valueTxb), int.Parse($"{valueTxb}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validateTextBoxsColor(sender).Item1)
            {
                this.BackColor = Color.FromArgb(validateTextBoxsColor(sender).Item2);
            }
        }

        // Utilizar formClosing
    }
}
