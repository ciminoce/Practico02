using System.Text;

namespace Ejercicio04.Entidades
{
    public static class TablaDeMultiplicar
    {
        public static string ObtenerTablaMultiplicar(int numero)
        {
            //StringBuilder tabla = new StringBuilder();

            //tabla.AppendLine($"Tabla de multiplicar del {numero}:");
            //for (int i = 1; i <= 10; i++)
            //{
            //    tabla.AppendLine($"{numero} x {i} = {numero * i}");
            //}

            return ObtenerTablaMultiplicar(numero, 1, 10);
        }

        public static string ObtenerTablaMultiplicar(int numero, int inicio, int final)
        {
            //Si el inicio es mayor al final, los cambio
            //Otra opción podría haber sido ir del mayor al menor en el ciclo
            if (inicio > final)
            {
                int aux=inicio;
                inicio=final;
                final=aux;
            }
            StringBuilder tabla = new StringBuilder();

            tabla.AppendLine($"Tabla de multiplicar del {numero}:");
            for (int i = inicio; i <= final; i++)
            {
                tabla.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return tabla.ToString();
        }

    }
}
