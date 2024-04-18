using Ejercicio03.Entidades;
using Practico02.Shared;

var numero1=ConsoleExtensions.ReadDouble("Ingrese el primer número:");
var numero2=ConsoleExtensions.ReadDouble("Ingrese el segundo número:");
        Console.WriteLine();
char operacion = ConsoleExtensions
        .GetValidOptions("Ingrese la operación a realizar (+, -, * o /):",
        new List<char> { '+', '-', '*', '/' });
var resultado = Calculadora.Calcular(numero1, numero2, operacion);
    if (!double.IsNaN(resultado))
    {
        Console.WriteLine($"\nEl resultado de la operación es: {resultado}");
    }

Console.ReadLine(); // Para evitar que la consola se cierre automáticamente
