using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qualquer texto ou frase");
            var frase = Console.ReadLine();
            Console.Clear();

            ServiceText service = new ServiceText();
            service.Call(EText.Options.Todos, frase);

            Console.ReadKey();
        }
    }
}
