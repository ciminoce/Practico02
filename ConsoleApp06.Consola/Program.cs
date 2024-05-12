using Practico02.Shared;
using System.Globalization;
var appCultura = CultureInfo.CreateSpecificCulture("es-AR");
CultureInfo.CurrentCulture = appCultura;
try
{
    Console.WriteLine();
    double baseTriangulo = ConsoleExtensions.ReadDouble(
        "Ingrese la base del triángulo en centímetros:", 
        appCultura);

    Console.WriteLine("Ingrese la altura del triángulo en centímetros:");
    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

    double hipotenusa = TrianguloUtils.CalcularHipotenusa(baseTriangulo, alturaTriangulo);

    Console.WriteLine($"La longitud de la hipotenusa es: {hipotenusa} cm");
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}