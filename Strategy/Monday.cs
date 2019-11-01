using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Monday : Weekdays
    {
        public String message()
        {
            return "Segunda-feira!";
        }
    }
}
