using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos.Salario
{
    internal class AumentoSalarial
    {
        public double aumentoSalario(double salario, double percentual)
        {
            double pAumento = salario * (percentual / 100);
            return pAumento+salario;
        }

        public double valorAumento(double salario, double percentual)
        {
            double pAumento = salario * (percentual / 100);
            return pAumento;
        }
    }
}
