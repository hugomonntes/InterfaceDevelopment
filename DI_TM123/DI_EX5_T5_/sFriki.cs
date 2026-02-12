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
        public string Nombre { set; get; }

        public int Edad { set; get; }

        public eAficion Aficion { set; get; }

        public eSexo Sexo { set; get; }

        public eSexo SexoOpuesto { set; get; }

        public string Foto { set; get; }

        public sFriki(string nombre, int edad, eAficion aficion, eSexo sexo, eSexo sexoOpuesto, string foto)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Aficion = aficion;
            this.Sexo = sexo;
            this.SexoOpuesto = sexoOpuesto;
            this.Foto = foto;
        }

        public sFriki()
        {
            
        }
    }
}
