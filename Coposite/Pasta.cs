using System;
using System.Collections.Generic;
using System.Text;

namespace Coposite
{
    class Pasta : IObjeto
    {
        //list : IComponent
        public List<IObjeto> Conteudo { get; set; }
        public String Nome { get; set; }
        public int Nivel { get; set; }

        public Pasta(String nome)
        {
            this.Nome = nome;
            this.Conteudo = new List<IObjeto>();
        }

        //Operation
        public void Adicionar(IObjeto o)
        {
            o.Nivel = this.Nivel + 3;
            this.Conteudo.Add(o);
        }

        //Operation
        public override string ToString()
        {
            String retorno = String.Format("\n",
                new String(' ', this.Nivel),
                this.Nome);

            foreach (var item in this.Conteudo)
            {
                retorno += item;
            }

            return retorno;
        }
    }
}
