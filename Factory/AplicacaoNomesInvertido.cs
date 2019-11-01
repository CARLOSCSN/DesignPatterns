using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class AplicacaoNomesInvertido : AplicacaoNomes
    {
        public override Nome construirNome(string nome)
        {
            string sobrenome = null;

            int pos = nome.IndexOf(",", StringComparison.Ordinal);
            if (pos != -1)
            {
                sobrenome = nome.Substring(0, pos).Trim();
                nome = nome.Substring(pos + 1, nome.Length - (pos + 1)).Trim();
            }

            return new Nome(nome, sobrenome);
        }
    }
}
