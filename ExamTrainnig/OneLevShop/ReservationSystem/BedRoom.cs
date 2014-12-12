using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class BedRoom : Room
    {
        public BedRoom(int rooomNumber, double price)
            : base()
        {
            this.RoomType = RoomTypes.Gold;
            this.BedCount = 2;
            this.HasRestRoom = true;
            this.HasBalcony = true;
            this.Extras = new List<string>() 
            { 
                "TV", 
                "air - conditioner",
                "refrigerator",
                "mini-bar", 
                "bathtub"
            };
            this.RoomNumber = rooomNumber;
            this.Price = price;
        }

        public override string GetTypeOfRoom()
        {
            return this.GetType().Name;
        }
    }
}
