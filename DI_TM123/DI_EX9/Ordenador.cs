using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX9
{
    internal class Ordenador
    {
        public string Nombre { set; get; }

        private int memoriaRAM;
        public int MemoriaRam
        {
            set
            {
                memoriaRAM = value < 0 ? value : 100;
            }
            get
            {
                return memoriaRAM;
            }
        }

        public static bool checkIP(string ip)
        {
            bool flag = true;  
            string[] ipSplited = ip.Split(".");
            if (ipSplited.Length == 4)
            {
                foreach (var ipElement in ipSplited)
                {
                    if (!byte.TryParse(ipElement, out _))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}