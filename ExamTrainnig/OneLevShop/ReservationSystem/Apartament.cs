using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class Apartament : Room
    {
        public Apartament(int rooomNumber, double price)
            : base()
        {
            this.RoomType = RoomTypes.Diamond;
            this.BedCount = 4;
            this.HasRestRoom = true;
            this.HasBalcony = true;
            this.Extras = new List<string>() 
            { 
                "TV", 
                "air - conditioner",
                "refrigerator",
                "mini-bar", 
                "bathtub",
                "kitchen box",
                "free Wi-fi"
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
