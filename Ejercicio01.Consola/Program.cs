using Ejercicio01.Entidades;

int[] numeros = new int[10];
int min = 100;
int max = -100;
int suma = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        if (Validador.Validar(numero, -100, 100))
        {
            numeros[i] = numero;
            suma += numero;
            if (numero < min)
                min = numero;
            if (numero > max)
                max = numero;
        }
        else
        {
            Console.WriteLine("El número ingresado no está dentro del rango permitido (-100 a 100).");
            i--; // Reintentar la misma posición
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Introduzca un número entero.");
        i--; // Reintentar la misma posición
    }
}

double promedio = (double)suma / 10;

Console.WriteLine($"El valor mínimo ingresado es: {min}");
Console.WriteLine($"El valor máximo ingresado es: {max}");
Console.WriteLine($"El promedio de los números ingresados es: {promedio}");

Console.ReadLine(); // Para evitar que la consola se cierre automáticamente
