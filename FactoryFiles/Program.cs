using System;

namespace FactoryFiles
{
    class Program
    {
        public static void Main(string[] args)
        {
            string senha = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("Digite a senha");
                    senha = Console.ReadLine();
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("valor invalido por favor tente novamente.");
                }

                if (string.IsNullOrWhiteSpace(senha))
                {
                    Console.WriteLine("Digite uma senha...");
                }
            }

            ProvedorInformacao provedorConfidencial = new ProvedorConfidencial();
            ProvedorInformacao provedorPublico = new ProvedorPublico();

            if (senha.Equals("designpatterns"))
            {
                provedorConfidencial.exibirInformacao();
            }
            else
            {
                provedorPublico.exibirInformacao();
            }

            Console.ReadLine();
        }
    }
}
