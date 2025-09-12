using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            textBox1.Text = getRandomNumber() + "";
            textBox2.Text = getRandomNumber() + "";
            textBox3.Text = getRandomNumber() + "";

            int saldo = int.Parse(lblSaldo.Text);
            int tx1 = int.Parse(textBox1.Text);
            int tx2 = int.Parse(textBox2.Text);
            int tx3 = int.Parse(textBox3.Text);

            if (tx1 == tx2 && tx2 == tx3)
            {
                lblPremio.Text = "WIN 20€";
                saldo += 20;
                lblSaldo.Text = saldo + "";
            }
            else if (tx1 == tx2 || tx1 == tx3 || tx2 == tx3)
            {
                lblPremio.Text = "WIN 5€";
                saldo += 5;
                lblSaldo.Text = saldo + "";

            }
            else
            {
                lblPremio.Text = "LOST 2€";
                saldo -= 2;
                lblSaldo.Text = saldo + "";
            }
        }

        public static int getRandomNumber()
        {
            return new Random().Next(1,8);
        }
    }
}
