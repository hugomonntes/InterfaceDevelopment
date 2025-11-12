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
                newButton.MouseLeave += (sender, e) =>
                {
                    newButton.BackColor = Color.Empty;
                };
                newButton.MouseDown += (sender, e) =>
                {
                    newButton.BackColor = Color.Chocolate;
                };
                this.Controls.Add(newButton);
            }
        }
        public Form1()
        {
            InitializeComponent();
            initButtons();
        }
    }
}

//Los botones deben ser creados e inicializados en tiempo de ejecución en
//el evento Load o en el Constructor del Formulario. 

//Las pulsaciones de los botones escriben su contenido en el TextBox.
//Además cuando el ratón pase por encima de cada uno, este cambiará de
//color resaltándolo y volviendo al color original al salir. Si se aprieta,
//cambiará a un tercer color que ya no se restaura.