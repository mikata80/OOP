using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public static class BookingManager
    {
        public static void BookRoom(Room room, Reservation reservation)
        {
            List<Reservation> roomReservations = room.Reservations;
            DateTime startDate = reservation.StartDate;
            DateTime endDate = reservation.EndDate;

            if (room.IsReserverdRoom(startDate,endDate))
            {
                room.addReservation(reservation);
                Console.WriteLine("Registration for =>\n\t" + room.ToString() + "\nwas successfull!");
            }
            else
            {
                Console.WriteLine("The room is reserverd for this period from {0} to {1}!",
                    reservation.StartDate,
                    reservation.EndDate);
                
            }
        }
    }
}
