using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos.desconto
{
    public static class CalculaDesconto
    {
        public static double valorDesconto(double valor, double desconto)
        {
            double vDesconto = (desconto / 100) * valor;
            return vDesconto;
        }
        public static double descontoProd(double valor, double desconto)
        {
            double vFinal = (desconto / 100) * valor;
            return valor - vFinal;
        }

        public static decimal CalcularDesconto(decimal valor, float percentual)
        {
            return valor * (decimal)percentual;
        }
    }
}