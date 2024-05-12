using Ejercicio04.Entidades;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                string tablaMultiplicar = TablaDeMultiplicar
                    .ObtenerTablaMultiplicar(numero);
                Console.WriteLine(tablaMultiplicar);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }
    }
}
