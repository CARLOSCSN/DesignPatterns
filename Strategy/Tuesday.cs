using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Tuesday : Weekdays
    {
        public String message()
        {
            return "Terça-feira!";
        }
    }
}
