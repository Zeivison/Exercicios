using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos.desconto
{
    internal class CalculaDesconto
    {
        public double valorDesconto(double valor, double desconto)
        {
            double vDesconto = (desconto / 100) * valor;
            return vDesconto;
        }
        public double descontoProd(double valor, double desconto)
        {
            double vFinal = (desconto / 100) * valor;
            return valor - vFinal;
        }
    }
}