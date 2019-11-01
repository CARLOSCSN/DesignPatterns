using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class AplicacaoNomesNormal : AplicacaoNomes
    {
        public override Nome construirNome(string nome)
        {
            string sobrenome = "";

            int pos = nome.IndexOf(" ", StringComparison.Ordinal);
            if (pos != -1)
            {
                sobrenome = nome.Substring(pos + 1, nome.Length - (pos + 1)).Trim();
                nome = nome.Substring(0, pos).Trim();
            }

            return new Nome(nome, sobrenome);
        }
    }
}
