using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ServiceText
    {
        public void Call(EText.Options option, string frase)
        {
            Text text = new Text(option);

            // chama o template method da classe TextBase
            switch (option)
            {
                case EText.Options.Maiusculo:
                    text.Maiusculo(frase);
                    break;
                case EText.Options.Minusculo:
                    text.Minusculo(frase);
                    break;
                case EText.Options.Duplicar:
                    text.Duplicar(frase);
                    break;
                case EText.Options.Inverter:
                    text.Inverter(frase);
                    break;
                case EText.Options.Todos:
                    text.Todos(frase);
                    break;
            }
        }
    }
}
