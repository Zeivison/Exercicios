using Exemplos.fixacao;

namespace TesteExemplosCSharp;

[TestClass]
public class TesteCalculaFatorial
{
    [TestMethod]
    public void TestMethod1()
    {
        CalcularFatorial calc = new CalcularFatorial();
        //cenario
        int num = 3;
        

        //ação
        int calculaFatorial = calc.CalculaFatorial(num);

        //verificação
        Assert.AreEqual(calculaFatorial, 6);
    }
}
