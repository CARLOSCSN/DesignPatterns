using System;
using _FacadeAux;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            _FacadeAux.Action.ComprarPassagemArea();

            Console.ReadKey();
        }
    }
}

// Library
namespace _FacadeAux
{
    // Subsystem A
    internal class Reserva
    {
        internal void Pesquisar(string reserva)
        {
            Console.WriteLine("Pesquisa a reserva '" + reserva + "'");
        }
    }

    // Subsystem B
    internal class Passagem
    {
        internal void PesquisarDestino(string destino)
        {
            Console.WriteLine("Pesquisa o destino '" + destino + "'");
        }

        internal void Comprar()
        {
            Console.WriteLine("Compra passagem");
        }

        internal void Visualizar()
        {
            Console.WriteLine("Visualiza a passagem");
        }       
    }

    // Subsystem C
    internal class Cliente
    {
        internal void Acao(string acao)
        {
            Console.WriteLine(acao);
        }
    }


    // Facade
    public static class Action
    {
        // Subsystem A
        static Passagem passagem = new Passagem();

        // Subsystem B
        static Reserva reserva = new Reserva();

        // Subsystem C
        static Cliente cliente = new Cliente();

        //Operation1
        public static void ComprarPassagemArea()
        {
            cliente.Acao("Faz Login");

            passagem.PesquisarDestino("Cidade do além");

            passagem.Comprar();

            reserva.Pesquisar("Reserva xyz");

            passagem.Visualizar();

            cliente.Acao("Confirma os dados");

            cliente.Acao("Imprimi o comprovante");

            cliente.Acao("Fecha o sistema");
        }
    }
}