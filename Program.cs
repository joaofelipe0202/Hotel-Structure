using System;

namespace Lab4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel joao = new Hotel("Joao", "123 Avenue");
            joao.CreateNewClient("Normal", 111111111);
            joao.CreateRoom("Joao", 5, 20);
            //Console.WriteLine(joao.ReserveRoom(joao.Rooms[0], joao.Clients[0], 6));

            joao.CreateRoom("Joao", "12", 2, "balcony", 340);
            Console.WriteLine(joao.ReserveRoom(joao.Rooms[1], joao.Clients[0], 2));  //false
           
        }
    }
}
