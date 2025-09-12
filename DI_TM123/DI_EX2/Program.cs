 namespace DI_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = Int32.Parse(Console.ReadLine());
   
            Console.Write("Peso: ");
            double peso = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nombre: {0,12}, Edad: {1,4},\n \tPeso: {2,5}", nombre, edad, peso);
        }
    }
}
