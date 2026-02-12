using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX5_T5_
{
    enum eAficion
    {
        Manga, SciFi, RPG, Fantasia, Terror, Tecnologia
    }

    enum eSexo
    {
        Hombre, Mujer
    }

    internal class sFriki
    {
        private string nombre;
        public string Nombre { set; get; }

        private int edad;
        public string Edad { set; get; }

        private eAficion aficion;
        public eAficion Aficion { set; get; }

        private eSexo sexo;
        public eSexo Sexo { set; get; }

        private eSexo sexoOpuesto;
        public eSexo SexoOpuesto { set; get; }

        private string foto;
        public string Foto { set; get; }
    }
}
