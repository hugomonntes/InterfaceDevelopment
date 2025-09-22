using System;
using System.Xml.Linq;

namespace DI_EX7
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Haz un programa principal(Mételo en otra clase distinta a las clases anteriores)
            //se crea una colección de Astros y el siguiente menú(Controls las excepciones de
            //las opciones de menú con TryParse):
            //• Añade Planeta: Pregunta si es gaseoso y pide el nombre y radio. También
            //pregunta cantidad de lunas.
            //• Añade Cometa: Pide su nombre y radio.
            //• Mostrar datos: para cada elemento indica si es terraformable.Además en el
            //caso de Cometa mostrará el nombre y en el caso de Planeta mostrará lo que
            //devuelva ToString.
            //• Incrementa / Decrementa n.º de satélites.Pide nombre del Astro y si existe
            //(usa IndexOf) y es de tipo Planeta se pregunta si se desea incrementar o
            //decrementar en una unidad el n.º de satélites.
            //• Eliminar no terraformables: Elimina todos los elementos que no sean
            //terraformables de la colección.
            //• Salir.Como siempre no sale de la aplicación hasta que se selecciona esta
            //opción.
            List<Astro> coleccionAstros = new List<Astro>();
            Console.WriteLine("Añadir Planeta: ");
        }
    }
}
