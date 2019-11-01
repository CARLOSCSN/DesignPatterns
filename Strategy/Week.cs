using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Week
    {
        public Weekdays getWeekdays(string weekdays)
        {
            try
            {
                //  Obter a instancia da classe desejada
                var obj = (Weekdays)Activator.CreateInstance(Type.GetType("Strategy." + weekdays));
                return obj;
            }
            catch (Exception exception)
            {
                //  Dia da semana invalido
                throw new Exception(("\'"
                                + (weekdays + "\' Dia da semana invalido!")));
            }

        }
    }
}
