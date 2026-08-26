using Exemplos.desconto;

namespace TesteExemplosCSharp;

[TestClass]
public class TesteCalculaDesconto
{
    [TestMethod]
    public void TestMethod1()
    {
        //cenario
        decimal valorAtual = 100;
        float percDesconto = 10;
        decimal valorDesconto = 10;
        decimal descontoCalculado;
        //ação
        descontoCalculado = CalculaDesconto.CalcularDesconto(valorAtual, percDesconto);

        //verificação
        Assert.AreEqual(valorDesconto, descontoCalculado);
    }
}
