using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class CapacityExceedException : Exception
    {
        public CapacityExceedException(string message) : base(message)
        {

        }
    }
}
