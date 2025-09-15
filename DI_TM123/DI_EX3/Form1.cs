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
            var randoms = getRandomNumber(1, 8);
            showRandomNumbers(randoms.Item1, randoms.Item2, randoms.Item3);
            updateWallet(int.Parse(lblSaldo.Text));
        }

        private static Random random = new Random();

        public static (int, int, int) getRandomNumber (int minRange, int maxRange)
        {
            return (random.Next(minRange, maxRange), random.Next(minRange, maxRange), random.Next(minRange, maxRange));
        }

        public void showRandomNumbers(int r1, int r2, int r3) 
        {
            textBox1.Text = string.Format("{0}", getRandomNumber(1, 8).Item1);
            textBox2.Text = string.Format("{0}", getRandomNumber(1, 8).Item2);
            textBox3.Text = string.Format("{0}", getRandomNumber(1, 8).Item3);
        }

        public void updateWallet(int saldo) 
        {
            int tx1 = int.Parse(textBox1.Text);
            int tx2 = int.Parse(textBox2.Text);
            int tx3 = int.Parse(textBox3.Text);

            if (tx1 == tx2 && tx1 == tx3)
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

        public int addMoney(int saldoToAdd,int saldo) 
        {
          return saldo += saldoToAdd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSaldo.Text = addMoney(10, int.Parse(lblSaldo.Text)).ToString();
        }
    }   // TODO separar visualizacion de datos de almacenamineto de datos
}
