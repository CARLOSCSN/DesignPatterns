using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroNomes = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Quantos nomes quer cadastrar");
                    numeroNomes = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("valor invalido por favor tente novamente.");
                }
            }

            List<string> listaNomesCompletos = new List<string>();

            for (int i = 0; i < numeroNomes; i++)
            {
                Console.WriteLine("Digite o nome completo");
                listaNomesCompletos.Add(Console.ReadLine()); // HERE !!
            }

            AplicacaoNomes aplicacaoNormal = new AplicacaoNomesNormal();
            AplicacaoNomes aplicacaoInvertido = new AplicacaoNomesInvertido();

            for (int i = 0; i < listaNomesCompletos.Count; i++)
            {
                if (listaNomesCompletos[i].Contains(","))
                {
                    
                    aplicacaoInvertido.adicionarNome(listaNomesCompletos[i]);
                }
                else
                {
                    aplicacaoNormal.adicionarNome(listaNomesCompletos[i]);
                }
            }

            Console.Clear();
            aplicacaoNormal.imprimirNomes();
            aplicacaoInvertido.imprimirNomes();
            Console.ReadLine();
        }
    }
}
