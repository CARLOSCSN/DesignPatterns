using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Saturday : Weekdays
    {
        public String message()
        {
            return "Sábado!";
        }
    }
}
