using System;
using System.Linq;

namespace Coposite
{
    class Program
    {
        static void Main(string[] args)
        {
            IObjeto veneza01 = new Arquivo("Passagem aérea");
            IObjeto veneza02 = new Arquivo("Hotel");
            IObjeto veneza03 = new Arquivo("6 diárias");

            IObjeto toquio01 = new Arquivo("Passagem aérea");
            IObjeto toquio02 = new Arquivo("Hotel");
            IObjeto toquio03 = new Arquivo("4 diárias");
            IObjeto toquio04 = new Arquivo("Café da manhã");

            IObjeto rio01 = new Arquivo("Passagem aérea");
            IObjeto rio02 = new Arquivo("Hotel");
            IObjeto rio03 = new Arquivo("10 diárias");
            IObjeto rio04 = new Arquivo("Café da manhã");
            IObjeto rio05 = new Arquivo("Almoço");
            IObjeto rio06 = new Arquivo("Visita ao Cristo Redentor");

            IObjeto pastaPrincipal = new Pasta("Viagens");
            IObjeto pacoteVeneza = new Pasta("Veneza");
            IObjeto pacoteToquio = new Pasta("Tóquio");
            IObjeto pacoteRio= new Pasta("Rio de Janeiro");

            pacoteVeneza.Adicionar(veneza01);
            pacoteVeneza.Adicionar(veneza02);
            pacoteVeneza.Adicionar(veneza03);

            pacoteToquio.Adicionar(toquio01);
            pacoteToquio.Adicionar(toquio02);
            pacoteToquio.Adicionar(toquio03);
            pacoteToquio.Adicionar(toquio04);

            pacoteRio.Adicionar(rio01);
            pacoteRio.Adicionar(rio02);
            pacoteRio.Adicionar(rio03);
            pacoteRio.Adicionar(rio04);
            pacoteRio.Adicionar(rio05);
            pacoteRio.Adicionar(rio06);

            pastaPrincipal.Adicionar(pacoteVeneza);
            pastaPrincipal.Adicionar(pacoteToquio);
            pastaPrincipal.Adicionar(pacoteRio);

            foreach (var conteudo in pastaPrincipal.Conteudo)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Pacote de Viagem - " + conteudo.Nome);

                foreach (var item in conteudo.Conteudo)
                {
                    Console.WriteLine("  " + item.Nome);
                }
            }

            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }
    }
}
