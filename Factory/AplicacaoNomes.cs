using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class AplicacaoNomes
    {
        private ISet<Nome> nomes = new HashSet<Nome>();

        public virtual void adicionarNome(string nome)
        {
            Nome novoNome = construirNome(nome);
            nomes.Add(novoNome);
        }

        public abstract Nome construirNome(string nome);

        public virtual void imprimirNomes()
        {
            foreach (Nome nome in nomes)
            {
                Console.WriteLine(nome.toString());
            }
        }
    }
}
