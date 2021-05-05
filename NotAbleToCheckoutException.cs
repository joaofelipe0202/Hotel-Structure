using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class NotAbleToCheckoutException : Exception
    {
        public NotAbleToCheckoutException(string message) : base(message)
        {

        }
    }
}
