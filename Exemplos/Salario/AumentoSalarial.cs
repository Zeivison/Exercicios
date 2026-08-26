using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos.Salario
{
    public class AumentoSalarial
    {
        public decimal aumentoSalario(decimal salario, float percentual)
        {
            decimal pAumento = salario * ((decimal)percentual / 100);
            return pAumento+salario;
        }

        public decimal valorAumento(decimal salario, float percentual)
        {
            decimal pAumento = salario * ((decimal)percentual / 100);
            return pAumento;
        }
    }
}
