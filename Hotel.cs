using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_OOP
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Address { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Client> Clients { get; set; }

        public Hotel(string hotelName, string address)
        {
            this.HotelName = hotelName;
            this.Address = address;
            this.Rooms = new List<Room>();
            this.Clients = new List<Client>();
        }
        public void CreateRoom(string hotelName, int capacity, string roomNumber)
        {
            roomNumber = roomNumber + hotelName.Substring(0, 3);

            //create a not ocuppied new room to add to the list of rooms
            Room hotelRoom = new Room(roomNumber, capacity);

            Rooms.Add(hotelRoom);
        }
        public void CreateRoom(string hotelName, string roomNumber, int capacity, string addAm, int vipValue)
        {
            roomNumber = roomNumber + hotelName.Substring(0, 3);
    
            //create a not ocuppied new premium room to add to the list of rooms
            PremiumRoom premiumHotelRoom = new PremiumRoom(roomNumber, capacity, addAm, vipValue);

            Rooms.Add(premiumHotelRoom);
        }

        public void CreateNewClient(string clientName, int cardNumber)
        {
            Client newClient = new Client(clientName, cardNumber);
            Clients.Add(newClient);
        }
        public void CreateNewClient(string clientName, int cardNumber, int vipNumber, int vipPoints)
        {
            VIPClient newVIPClient = new VIPClient(clientName, cardNumber, vipNumber, vipPoints);
            Clients.Add(newVIPClient);
        }
        public bool ReserveRoom(Room room, Client client, int occupants)
        {

            //if the number of occupants is higher than room capacity and the room is not occupied do the reservation 
            try
            {
                if (room.Ocuppied)
                {
                    throw new RoomOcuppiedException("Sorry, this room is already ocuppied");
                }
                if(occupants > room.Capacity)
                {
                    throw new CapacityExceedException("The number of ocuppants exceeds the room capacity, please try another room");
                }
                //create a new reservation
                Reservation newReservation = new Reservation(DateTime.Now, occupants, client, room);
                room.Ocuppied = true;
                newReservation.IsCurrent = true;

                if (client is VIPClient vipClient && room is PremiumRoom premiumRoom)
                {   
                    //if a client is vip and get a premium room it's value will be add to the VIP points
                    vipClient.VIPPoints += premiumRoom.VIPValue;
                }
                return true;
            }
            catch(NotAbleToReserveException)
            {
                //throw new NotAbleToReserveException("Sorry, this room can't be booked");

                return false;
            }
        }
        public void CheckoutRoom(Room roomToCheckout)
        {
            try
            {
                foreach (var room in Rooms)
                {
                    //if the room is the roomToCheckout change the room status
                    if (room == roomToCheckout)
                    {
                        Reservation lastReservation = roomToCheckout.Reservations[room.Reservations.Count - 1];
                        roomToCheckout.Ocuppied = false;
                        lastReservation.IsCurrent = false;

                    }
                }
            }
            catch (NotAbleToCheckoutException)
            {
                throw new NotAbleToCheckoutException("Sorry, the checkout can't be finalized");
            }
        }
        public void CheckoutRoom(Client clientToLeave)
        {
            try
            {
                foreach (var client in Clients)
                {
                    if (clientToLeave == client)
                    {
                        Reservation lastReservation = clientToLeave.Reservations[client.Reservations.Count - 1];
                        lastReservation.IsCurrent = false;
                        lastReservation.Room.Ocuppied = false;
                    }
                }
            }
            catch (NotAbleToCheckoutException)
            {
                throw new NotAbleToCheckoutException("Sorry, the checkout can't be finalized");
            }
        }

    
    }
}
