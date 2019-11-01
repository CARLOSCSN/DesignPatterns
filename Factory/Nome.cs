using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Nome
    {
        private string nome;
        private string sobrenome;

        public Nome(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public string toString()
        {
            return nome + " " + sobrenome;
        }
    }
}
