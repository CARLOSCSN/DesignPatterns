using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Text : TextBase
    {
        private EText.Options option;
        private string result = "";

        public Text(EText.Options _option)
        {
            option = _option;
        }

        public override void Duplicar(string frase)
        {
            result = "Duplicado - " + frase + " | " + frase;

            Console.WriteLine(result);
        }

        public override void Inverter(string frase)
        {
            char[] arr = frase.ToCharArray();
            Array.Reverse(arr);
            result = "Invertido - " + new string(arr);

            Console.WriteLine(result);
        }

        public override void Maiusculo(string frase)
        {
            result = "Maiusculo - " + frase.ToUpper();

            Console.WriteLine(result);
        }

        public override void Minusculo(string frase)
        {
            result = "Minusculo - " + frase.ToLower();

            Console.WriteLine(result);
        }
    }
}
