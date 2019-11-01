using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Carro
    {
        private double _preco = -1;
        private string _descricao = "Carro Abstrato.";

        public virtual double Preco
        {
            get { return _preco; }
        }
        public virtual string Descricao
        {
            get { return _descricao; }
        }
    }
}
