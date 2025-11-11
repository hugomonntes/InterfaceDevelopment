using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DI_EX5_T5
{
    internal class Program
    {
        public static void initButtons()
        {
            
        }
        static void Main(string[] args)
        {
            
        }
    }
}

//Realizar un formulario que simule el teclado de un móvil en modo teléfono
//mediante un TextBox y 12 botones (10 dígitos, * y #). No son necesarias las
//tres/cuatro letras pequeñas que hay debajo de cada número. Además tendrá
//las siguientes especificaciones:

//• Los botones deben ser creados e inicializados en tiempo de ejecución en
//el evento Load o en el Constructor del Formulario.

//• Las pulsaciones de los botones escriben su contenido en el TextBox.
//Además cuando el ratón pase por encima de cada uno, este cambiará de
//color resaltándolo y volviendo al color original al salir. Si se aprieta,
//cambiará a un tercer color que ya no se restaura.

//• Al pulsar las teclas, si son números, * o #, también aparecen en el
//TextBox.

//• Debe existir también un botón de Reset (este creado en tiempo de
//diseño) que borra el TextBox y deja todos los botones del color original.

//• Tendrá un pequeño menú con dos encabezados: Archivo y Acerca de...
//En Archivo habrá las opciones Grabar número, Mostrar agenda, Reset,
//separador y Salir (Finaliza la aplicación). Acerca de dará información de
//la app y el autor en un MessageBox con icono de información y botón
//único.

//◦ Grabar número: Saca un formulario secundario donde se pide un
//nombre. Tendrá botón Aceptar. Al pulsarlo añade a un archivo de
//texto predefinido el nombre que hay en el TextBox del secundario y
//al lado el número que haya en el TextBox del principal (la única
//comprobación es que haya algo en ambos textboxes). No debe haber
//código en el secundario.

//En el archivo cada par nombre:numero estará en una línea.
//◦ Mostrar agenda: Saca un secundario no modal con un textbox no
//editable que ocupa todo el formulario. Mostrará todos los datos de la
//agenda mostrándolos en dos columnas bien alineadas. Una para los
//nombres y otra para los teléfonos. Si ya está visible no debe sacar
//otro.

//◦ Reset hará lo mismo que el botón y salir saldrá del programa sin
//pedir confirmación.