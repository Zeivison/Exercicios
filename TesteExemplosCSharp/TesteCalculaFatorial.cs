namespace TesteExemplosCSharp;

[TestClass]
public class TesteCalculaFatorial
{
    [TestMethod]
    public void TestMethod1()
    {
        //cenario
        int num = 3;
        int fatorialCalculada;

        //ação
        calculaFatorial = CalcularFatorial.CalculaFatorial(num);

        //verificação
        Assert.AreEqual(fatorialCalculada, 6);
    }
}
