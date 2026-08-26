using Exemplos.Salario;

namespace TesteExemplosCSharp
{
    [TestClass]
    public sealed class TesteCalculaAumento
    {
        [TestMethod]
        public void TesteCalcularAumento()
        {
            //cenario
            decimal salario = 1000;
            float percentual = 10;
            decimal valorAumento;
            AumentoSalarial calc = new AumentoSalarial();

            //ação
            valorAumento = calc.valorAumento(salario, percentual);
            //verificação
            Assert.AreEqual(valorAumento, 100);

        }
    }
}
