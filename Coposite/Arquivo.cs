using System;
using System.Collections.Generic;
using System.Text;

namespace Coposite
{
    class Arquivo : IObjeto
    {
        public String Nome { get; set; }
        public int Nivel { get; set; }
        public List<IObjeto> Conteudo { get; set; }

        public Arquivo(String nome)
        {
            this.Nome = nome;
        }

        //Operation
        public void Adicionar(IObjeto o)
        {
            Console.Write("não permitido");
        }

        //Operation
        public override string ToString()
        {
            return String.Format("\n",
                new String(' ', this.Nivel),
                this.Nome);
        }
    }
}
