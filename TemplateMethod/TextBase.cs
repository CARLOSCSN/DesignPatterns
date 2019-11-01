using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class TextBase
    {
        // esqueleto dos métodos
        public abstract void Maiusculo(string frase);
        public abstract void Minusculo(string frase);
        public abstract void Duplicar(string frase);
        public abstract void Inverter(string frase);

        // template method
        public virtual void Todos(string frase)
        {
            Maiusculo(frase);
            Minusculo(frase);
            Duplicar(frase);
            Inverter(frase);
        }
    }
}
