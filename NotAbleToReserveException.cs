using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class NotAbleToReserveException : Exception
    {
        public NotAbleToReserveException(string message) : base(message)
        {

        }
    }
}
