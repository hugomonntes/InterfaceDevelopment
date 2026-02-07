using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_EX4_T5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        public string selectRandomWord(string[] words)
        {
            return words[random.Next(0, words.Length)];
        }

        public string[] readFile(string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.GetEnvironmentVariable("appdata")}\\filename.txt"))
                {
                    string content = sr.ReadToEnd();
                    if (content.Length > 0)
                    {
                        return content.Trim().Split(',');
                    }
                    return new string[0];
                }
            } catch (IOException)
            {
                return new string[0];
            }
        }
    }
}
