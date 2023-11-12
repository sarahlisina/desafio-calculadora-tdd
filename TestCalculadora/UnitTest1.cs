using Calculadora;

namespace TestCalculadora
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(4, 2, 6)]
        [InlineData(3, 1, 4)]
        public void Somar(int num1, int num2, int resultadoEsperado)
        {
            int soma = Calculadora.Calculadora.Somar(num1, num2);
            Assert.Equal(resultadoEsperado, soma);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(3, 1, 2)]
        public void TestSubtrair(int num1, int num2, int resultadoEsperado)
        {
            int resultado = Calculadora.Calculadora.Subtrair(num1, num2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(4, 2, 8)]
        [InlineData(3, 1, 3)]
        public void TestMultiplicar(int num1, int num2, int resultadoEsperado)
        {
            int resultado = Calculadora.Calculadora.Multiplicar(num1, num2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(4, 4, 1)]
        [InlineData(3, 3, 1)]
        public void TestDividir(int num1, int num2, int resultadoEsperado)
        {
            int resultado = Calculadora.Calculadora.Dividir(num1, num2);
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}