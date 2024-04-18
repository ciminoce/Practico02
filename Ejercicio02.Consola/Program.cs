using Ejercicio02.Entidades;

Console.WriteLine("Ingrese un número entero para convertirlo a binario:");
if (int.TryParse(Console.ReadLine(), out int numeroDecimal))
{
    string binario = Conversor.ConvertirDecimalABinario(numeroDecimal);
    Console.WriteLine($"El número {numeroDecimal} en binario es: {binario}");
}
else
{
    Console.WriteLine("Entrada no válida. Introduzca un número entero.");
}

Console.WriteLine("\nIngrese un número binario para convertirlo a decimal:");
string numeroBinario = Console.ReadLine();
if (Conversor.EsBinario(numeroBinario))
{
    int decimalConvertido = Conversor.ConvertirBinarioADecimal(numeroBinario);
    Console.WriteLine($"El número binario {numeroBinario} en decimal es: {decimalConvertido}");
}
else
{
    Console.WriteLine("El número ingresado no es binario válido.");
}

Console.ReadLine(); // Para evitar que la consola se cierre automáticamente

