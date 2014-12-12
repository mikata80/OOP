using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public interface IReservable
    {
        void addReservation(Reservation resr);

        void removeReservation(Reservation resr);
    }
}
