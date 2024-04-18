namespace Ejercicio03.Entidades
{
    public static class Calculadora
    {
        public static double Calcular(double operando1, double operando2, char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return operando1 + operando2;
                case '-':
                    return operando1 - operando2;
                case '*':
                    return operando1 * operando2;
                case '/':
                    if (Validar(operando2))
                        return operando1 / operando2;
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                        return double.NaN; // Retorna NaN (Not a Number) en caso de división por cero
                    }
                default:
                    Console.WriteLine("Error: Operación no válida.");
                    return double.NaN; // Retorna NaN en caso de operación no válida
            }
        }

        private static bool Validar(double operando2)
        {
            return operando2 != 0;
        }
    }
}
