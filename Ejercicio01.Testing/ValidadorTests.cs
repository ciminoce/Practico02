using Ejercicio01.Entidades;

namespace Ejercicio01.Testing
{
    [TestClass]
    public class ValidadorTests
    {
        [TestMethod]
        public void Validar_NumeroDentroDelRango_ReturnsTrue()
        {
            // Arrange
            int valor = 5;
            int min = 0;
            int max = 10;

            // Act
            bool resultado = Validador.Validar(valor, min, max);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Validar_NumeroFueraDelRango_ReturnsFalse()
        {
            // Arrange
            int valor = 15;
            int min = 0;
            int max = 10;

            // Act
            bool resultado = Validador.Validar(valor, min, max);

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Validar_NumeroIgualAlMinimo_ReturnsTrue()
        {
            // Arrange
            int valor = 0;
            int min = 0;
            int max = 10;

            // Act
            bool resultado = Validador.Validar(valor, min, max);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Validar_NumeroIgualAlMaximo_ReturnsTrue()
        {
            // Arrange
            int valor = 10;
            int min = 0;
            int max = 10;

            // Act
            bool resultado = Validador.Validar(valor, min, max);

            // Assert
            Assert.IsTrue(resultado);
        }
    }
}