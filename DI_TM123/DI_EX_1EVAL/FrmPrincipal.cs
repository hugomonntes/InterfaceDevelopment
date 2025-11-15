using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX_1EVAL
{
    public partial class FrmPrincipal : Form
    {
        public void initCheckBoxes(int numeroDeCheckBoxes)
        {
            ToolTip tooltip = new ToolTip();
            int x = 30;
            int y = 30;
            for (int i = 0; i < numeroDeCheckBoxes; i++)
            {
                CheckBox newCb = new CheckBox();
                newCb.Text = $"{i + 1}";
                newCb.Height = 30;
                newCb.Width = 45;
                newCb.Left = x;
                newCb.Top = y;
                x += 45;
                if (i % 6 == 5)
                {
                    x = 30;
                    y += 40;
                }
                newCb.CheckedChanged += (sender, e) =>
                {
                    tooltip.SetToolTip(newCb, $"{newCb.Checked}");
                };
                this.Controls.Add(newCb);
            }
        }

        public void animacionColorBotones(Button[] btns)
        {
            Timer tm = new Timer();
            tm.Interval = 300;
            tm.Start();

            int i = 0;
            tm.Tick += (sender, e) =>
            {
                if (btns[i].BackColor == Color.Beige)
                {
                    btns[i].BackColor = Color.Yellow;
                }
                else
                {
                    btns[i].BackColor = Color.Beige;
                }


                i++;
                if (i >= btns.Length)
                {
                    i = 0;
                }
            };
        }
        public FrmPrincipal()
        {
            InitializeComponent();
            initCheckBoxes(49);
            Button[] btns = { btnJugar, btnReset, btnSalir};
            animacionColorBotones(btns);
        }
    }
}
