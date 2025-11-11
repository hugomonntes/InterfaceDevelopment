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
