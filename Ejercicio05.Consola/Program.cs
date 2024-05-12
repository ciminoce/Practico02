using Ejercicio05.Entidades;

namespace Ejercicio05.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            Console.WriteLine("Ingrese la longitud del lado del cuadrado:");
            double longitudLadoCuadrado = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo:");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el radio del círculo:");
            double radioCirculo = double.Parse(Console.ReadLine());

            // Cálculo del área y visualización de resultados
            double areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(longitudLadoCuadrado);
            Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");

            double areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
            Console.WriteLine($"El área del triángulo es: {areaTriangulo}");

            double areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);
            Console.WriteLine($"El área del círculo es: {areaCirculo}");
        }
    }
}
