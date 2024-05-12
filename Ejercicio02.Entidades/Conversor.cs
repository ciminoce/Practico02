using System.Text.RegularExpressions;

namespace Ejercicio02.Entidades
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            return Convert.ToString(numeroEntero, 2);
        }

        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            return Convert.ToInt32(numeroBinario, 2);
        }

        public static bool EsBinarioRegex(string numero)
        {
            /*
             * Este patrón busca una cadena que cumpla con las siguientes condiciones:

                ^: Indica el inicio de la cadena.
                [01]+: Busca uno o más dígitos que sean 0 o 1. El [01] especifica un dígito que puede ser 0 o 1, y el + indica que ese patrón debe aparecer al menos una vez.
                $: Indica el final de la cadena.
             */
            return Regex.IsMatch(numero, "^[0-1]+$");
        }

        public static bool EsHexaRegex(string numero)
        {
            /*
             * Esta expresión regular busca una cadena que cumpla con las siguientes condiciones:

                ^: Indica el inicio de la cadena.
                [0-9a-fA-F]+: Busca uno o más caracteres que pueden ser dígitos del 0 al 9 o letras de la A a la F (mayúsculas o minúsculas).
                $: Indica el final de la cadena.
             */
            return Regex.IsMatch(numero, "^[0-9,a-f,A-F]+$");
        }
        public static bool EsBinario(string numero)
        {
            foreach (char digito in numero)
            {
                if (digito != '0' && digito != '1')
                    return false;
            }
            return true;
        }
        public static string PasarDecimalABinario(int numeroEntero)
        {
            if (numeroEntero < 0)
            {
                throw new ArgumentException("El número entero debe ser mayor o igual que cero.");
            }

            if (numeroEntero == 0)
            {
                return "0";
            }

            string binario = "";
            while (numeroEntero > 0)
            {
                binario = (numeroEntero % 2) + binario;
                numeroEntero /= 2;
            }

            return binario;
        }

        public static int PasarBinarioADecimal(string numeroBinario)
        {
            if (!EsBinario(numeroBinario))
            {
                throw new ArgumentException("El número binario ingresado no es válido.");
            }

            int decimalResultado = 0;
            int exponente = 0;
            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                if (numeroBinario[i] == '1')
                {
                    decimalResultado += (int)Math.Pow(2, exponente);
                }
                exponente++;
            }

            return decimalResultado;
        }

        public static string ConvertirDecimalAHexadecimal(int numeroEntero)
        {
            if (numeroEntero < 0)
            {
                throw new ArgumentException("El número entero debe ser mayor o igual que cero.");
            }

            if (numeroEntero == 0)
            {
                return "0";
            }

            string hexadecimal = "";
            while (numeroEntero > 0)
            {
                int residuo = numeroEntero % 16;
                if (residuo < 10)
                {
                    hexadecimal = residuo + hexadecimal;
                }
                else
                {
                    hexadecimal = (char)(residuo - 10 + 'A') + hexadecimal;
                }
                numeroEntero /= 16;
            }

            return hexadecimal;
        }
    }
}
