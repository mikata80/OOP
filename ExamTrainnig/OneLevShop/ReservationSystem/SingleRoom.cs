using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class SingleRoom :Room
    {
        public SingleRoom(int rooomNumber, double price)
            :base()
        {
            this.RoomType = RoomTypes.Standard;
            this.BedCount = 1;
            this.HasRestRoom = true;
            this.HasBalcony = false;
            this.Extras = new List<string>() { "TV", "air - conditioner"};
            this.RoomNumber = rooomNumber;
            this.Price = price;
        }
    }
}
