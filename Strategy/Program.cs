using System;
using System.Globalization;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateParse = "";
            var dataInput = "";

            while (true)
            {
                try
                {
                    Console.WriteLine("Para saber o dia da semana por favor insira uma data no formato dd/mm/aaaa");
                    dataInput = Console.ReadLine();
                    dateParse = string.IsNullOrWhiteSpace(dataInput) ? DateTime.Now.ToString("dd/MM/yyyy") 
                        : DateTime.Parse(dataInput, new CultureInfo("pt-BR")).ToString("dd/MM/yyyy");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Data invalida por favor tente novamente.");
                }
            }

            var dateTime = DateTime.Parse(dateParse, new CultureInfo("pt-BR"));
            Week week = new Week();
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            var message = week.getWeekdays(calendar.GetDayOfWeek(dateTime).ToString()).message();
            Console.WriteLine(string.IsNullOrWhiteSpace(dataInput) ? "Hoje é " + message : "Este dia foi " + message);
            Console.ReadKey();
        }
    }
}
