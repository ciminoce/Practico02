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
