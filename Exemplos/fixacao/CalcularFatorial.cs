using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos.fixacao
{
    public class CalcularFatorial
    {
        public int CalculaFatorial(int numero)
        {
            int fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
