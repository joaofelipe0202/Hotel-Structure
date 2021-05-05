using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class Room
    {
        public string Number { get; set; }
        public int Capacity { get; set; }

        public bool Ocuppied { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Room(string number, int capacity)
        {
            this.Number = number;
            this.Capacity = capacity;
            this.Ocuppied = false;
            this.Reservations = new List<Reservation>();
        }
    }
    public class PremiumRoom : Room
    {
        public string AdditionalAmmenities { get; set; }
        public int VIPValue { get; set; }
        public PremiumRoom(string number, int capacity, string addAm, int vipValue) : base(number, capacity)
        {
            this.AdditionalAmmenities = addAm;
            this.VIPValue = vipValue;
        }


    }

}
