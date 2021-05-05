using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class RoomOcuppiedException : Exception
    {
        public RoomOcuppiedException(string message) : base(message)
        {

        }
    }
}
