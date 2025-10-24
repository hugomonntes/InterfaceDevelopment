using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX1_T4
{
    public partial class Form_Ex1 : Form //TODO Revisar coordenadas. 
    {
        String originalTitle;
        public Form_Ex1()
        {
            InitializeComponent();
            originalTitle = this.Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            if (sender is Button)
            {   
                int senderX = ((Button)sender).Location.X + x;
                int senderY = ((Button)sender).Location.Y + y;
                this.Text = $"Coordenadas X: {senderX}, Coordenadas Y: {senderY}";
            }
            this.Text = $"Coordenadas X: {x}, Coordenadas Y: {y}";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = originalTitle;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left)
            {
                button1.BackColor = Color.Yellow;
            }
            else if (e.Button is MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Orange;
                button2.BackColor = Color.Orange;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button is MouseButtons.Left)
            {
                button1.BackColor = Color.Empty;
            }
            else if (e.Button is MouseButtons.Right)
            {
                button2.BackColor = Color.Empty;
            }
            else
            {
                button1.BackColor = Color.Empty;
                button2.BackColor = Color.Empty;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();
            if (e.KeyCode is Keys.Escape)
            {
                Text = originalTitle;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int counter = 0;
            int counterLocationX = 150;
            int counterLocationY = 200;
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Text = $"Boton{counter + 1}";
                btn.Size = new System.Drawing.Size(75, 23);
                btn.Location = new System.Drawing.Point(counterLocationX, counterLocationY);
                counter++;

                counterLocationX += 100;
                if (counter % 5 == 0)
                {
                    counterLocationX = 150;
                    counterLocationY += 50;
                }

                btn.MouseDown += buttonGroup_Down;
                btn.MouseUp += buttonGroup_Up;
                btn.MouseMove += Form1_MouseMove;
                Controls.Add(btn);
            }
        }

        public void buttonGroup_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
        }

        public void buttonGroup_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar el programa?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}