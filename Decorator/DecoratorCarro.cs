using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class DecoratorCarro : Carro
    {
        double _preco = -1;
        string _descricao = "Decorador Abstrato de Carro";

        public override double Preco
        {
            get { return _preco; }
        }
        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
