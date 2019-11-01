using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            /// **** Teste 01 ****

            //// criar um carro
            //Console.WriteLine(" --------------Ferrari Padrão-----------------------");
            //Carro carro = new FerrariSpider();
            //Console.WriteLine("Descricao --> " + carro.Descricao.TrimEnd(' ', ','));
            //Console.WriteLine("Preco -->" + carro.Preco.ToString());
            //Console.ReadLine();

            //Console.WriteLine(" --------------Ferrari Decorada---------------------");
            //// decora o carro com banco de couro
            //carro = new Ferrari_Couro(carro);
            //// decora o carro com motor turbo
            //carro = new Ferrari_Turbo(carro);
            //Console.WriteLine("Descricao --> " + carro.Descricao.TrimEnd(' ', ','));
            //Console.WriteLine("Preco -->" + carro.Preco.ToString());
            //Console.ReadLine();

            /// **** Teste 02 ****

            Console.WriteLine(" -------------- Formato 01 ---------------------");
            BaseUm item = new NumeroUm();
            item = new Parenteses(item);
            item = new Colchetes(item);
            item = new Chaves(item);
            Console.WriteLine(item.Um);

            Console.WriteLine(" -------------- Formato 02 ---------------------");
            item = new NumeroUm();
            item = new Chaves(item);
            item = new Parenteses(item);
            item = new Colchetes(item);
            Console.WriteLine(item.Um);

            Console.WriteLine(" -------------- Formato 03 ---------------------");
            item = new NumeroUm();
            item = new Colchetes(item);
            item = new Chaves(item);
            item = new Parenteses(item);
            Console.WriteLine(item.Um);

            Console.ReadLine();
        }
    }
}
