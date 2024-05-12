namespace ConsoleApp06.Entidades
{
    public static class TrianguloUtils
    {
        public static double CalcularHipotenusa(double baseTriangulo,
            double alturaTriangulo)
        {
            // Calcular la longitud de la hipotenusa usando el Teorema de Pitágoras
            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2)
                + Math.Pow(alturaTriangulo, 2));
            return hipotenusa;
        }
    }

}
