namespace Practico02.Shared
{
    public static class ConsoleExtensions
    {
        public static string ReadString(string message)
        {
            string? stringVar = string.Empty;
            while (true)
            {

                Console.Write(message);
                stringVar = Console.ReadLine();
                if (stringVar == null)
                {
                    Console.WriteLine("Debe ingresar algo!!!");
                }
                else
                {
                    break;
                }
            }
            return stringVar;
        }

        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
            }
        }

        public static int ReadInt(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
            }
        }
        public static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número double válido.");
                }
            }
        }

        public static double ReadDouble(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número double válido.");
                }
            }
        }

        public static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número decimal válido.");
                }
            }
        }

        public static decimal ReadDecimal(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal result))
                {
                    if (result >= min && result <= max)
                    {
                        return result;

                    }
                    else
                    {
                        Console.WriteLine($"Selección fuera de rango ({min}-{max}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número decimal válido.");
                }
            }
        }


        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        /// <summary>
        /// Método para mostrar un mensaje y validar que el 
        /// caracter ingresado sea uno de la lista suministrada
        /// </summary>
        /// <param name="message">Mensaje que sale en pantalla</param>
        /// <param name="options">Listado de caracteres aceptados</param>
        /// <returns>El caracter ingresado luego de la validación</returns>
        public static char GetValidOptions(string message, List<char> options)
        {
            char answer;
            do
            {
                Console.Write(message);
                answer = Console.ReadKey().KeyChar;//Lee el caracter tipiado en la consola y lo convierte a char
                if (!options.Any(x => x.Equals(answer)))
                {
                    Console.WriteLine("Ingreso no válido... Otra vez!!!");
                }
                else
                {
                    /*
                     * Si la opción tipiada es alguna de la lista, salgo del ciclo
                     */
                    break;

                }

            } while (!options.Any(x => x.Equals(answer)));// mientras no sea un caracter válido me quedo esperando
            return answer; //retorno el caracter ingresado y validado.
        }

    }
}
