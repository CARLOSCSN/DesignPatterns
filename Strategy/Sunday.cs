using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Sunday : Weekdays
    {
        public String message()
        {
            return "Domingo!";
        }
    }
}
