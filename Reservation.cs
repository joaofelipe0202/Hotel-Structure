using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class Reservation
    {
        public DateTime ReservationDate { get; set; }
        public int Occupants { get; set; }

        public bool IsCurrent { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }
      
        public Reservation(DateTime date, int occupants, Client client, Room room)
        {
            this.ReservationDate = date;
            this.Occupants = occupants;
            this.IsCurrent = true;
            this.Client = client;
            this.Room = room;
        }

    }
}
