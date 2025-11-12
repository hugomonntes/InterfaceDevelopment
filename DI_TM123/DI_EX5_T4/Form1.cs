using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX5_T4
{
    public partial class Form1 : Form
    {
        public void initButtons()
        {
            int coordX = 10;
            int coordY = 10;
            string[] buttonText = new string[] {
                "1","2","3",
                "4","5","6",
                "7","8","9",
                "*","0","#"
            };

            for (int i = 0; i < buttonText.Length; i++)
            {
                bool isPressed = false;
                Button newButton = new Button();
                newButton.Text = buttonText[i];
                newButton.Left = coordX;
                newButton.Top = coordY;
                coordX += 100;
                if ((i + 1) % 3 == 0)
                {
                    coordX = 10;
                    coordY += 50;
                }
                newButton.MouseEnter += (sender, e) =>
                {
                    newButton.BackColor = Color.BurlyWood;
                };

                newButton.MouseDown += (sender, e) =>
                {
                    newButton.BackColor = Color.DarkOrchid;
                    isPressed = true;
                };

                if (!isPressed)
                {
                    newButton.MouseLeave += (sender, e) =>
                    {
                        newButton.BackColor = Color.Empty;
                    };
                }

                newButton.Click += (sender, e) =>
                {
                    textBox1.Text += newButton.Text; 
                };

                this.Controls.Add(newButton);
            }
        }

        public void resetItems(Control.ControlCollection Controls)
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Text = ""; // TODO
                ctrl.BackColor = Color.Empty;
            }
        }

        public Form1()
        {
            InitializeComponent();
            initButtons();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetItems(Controls);
        }
    }
}

//Al pulsar las teclas, si son números, * o #, también aparecen en el
//TextBox.

//• Debe existir también un botón de Reset (este creado en tiempo de
//diseño) que borra el TextBox y deja todos los botones del color original