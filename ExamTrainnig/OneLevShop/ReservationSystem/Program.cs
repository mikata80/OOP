using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class Program
    {
        static void Main()
        {
            SingleRoom room = new SingleRoom(1408, 99);

            List<Room> rooms = new List<Room>()
            {
             
                new SingleRoom(1401, 75.20),
                new SingleRoom(1402, 63.20),
                new SingleRoom(1403, 99.50),
                new BedRoom(1008, 120.20),
                new BedRoom(1009, 150.20),
                new BedRoom(1010, 180.20),
                new Apartament(908, 150),
                new Apartament(909, 550),
                new Apartament(910, 850)
            };

            List<Guest> guests = new List<Guest>()
            {
                new Guest("Svetlin", "Nakov", "8003224277"),
                new Guest("Milen", "Petrov", "8003123121277"),
                new Guest("Joro", "Toshev", "56038976546"),
                new Guest("Pesho", "Peshev", "21323187897")
            };

            Object[] all = {rooms,guests};

            Console.WriteLine();


            var res = rooms.Where(r => 
                r.Extras.Contains("bathtub")).
                OrderBy(rn => rn.RoomNumber);

            foreach (var r in res)
            {
                Console.WriteLine(r.ToString());
            }
            Console.WriteLine("========================");

            var res1 = rooms.Where(r =>
               (r.GetType().Name == "BedRoom" ||
               r.GetType().Name == "Apartament") &&
               r.Price <= 250.00).
               OrderBy(rn => rn.RoomNumber);

            foreach (var r in res1)
            {
                Console.WriteLine(r.ToString());
            }         

            //Guest guest = new Guest("Svetlin", "Nakov", "8003224277");

            //DateTime startDate = new DateTime(2014,10,24);
            //DateTime endDate = new DateTime(2014, 10, 26);
            //Reservation reservation = new Reservation(startDate, endDate, guest);
            ////room.addReservation(reservation);
            ////Console.WriteLine(room.ToString());
            //BookingManager.BookRoom(room, reservation);
            //BookingManager.BookRoom(room, reservation);

        }
    }
}
