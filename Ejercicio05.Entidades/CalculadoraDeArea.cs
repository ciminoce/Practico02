namespace Ejercicio05.Entidades
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double @base, double altura)
        {
            //Si pone @base para que no tome base como palabra reservada
            return 0.5 * @base * altura;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }
    }

}
