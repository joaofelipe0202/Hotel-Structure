using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class Client
    {
        public string Name { get; set; }
        private int CreditCardNumber { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Client(string name, int cardNumber)
        {
            this.Name = name;
            this.CreditCardNumber = cardNumber;
            this.Reservations = new List<Reservation>();
        }
    }
    public class VIPClient : Client
    {
        public int VIPNumber { get; set; }
        public int VIPPoints { get; set; }

        public VIPClient(string name, int cardNumber, int vipNumber, int vipPoints) : base(name, cardNumber)
        {
            this.VIPNumber = vipNumber;
            this.VIPPoints = vipPoints;
        }
    }

}
