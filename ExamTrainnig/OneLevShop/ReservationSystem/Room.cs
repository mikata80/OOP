using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public abstract class Room : IReservable
    {
        public RoomTypes RoomType { get; set; }

        public bool HasRestRoom { get; set; }

        public bool HasBalcony { get; set; }

        public int BedCount { get; set; }

        public int RoomNumber { get; set; }

        public List<string> Extras  { get; set; }

        public double Price { get; set; }

        public List<Reservation> Reservations = new List<Reservation>();

        public Room(RoomTypes roomType, bool hasRestRoom, bool hasBalcony,
            int bedCount, int roomNumber, List<string> extras, double price)
        {
            this.RoomType = roomType;
            this.HasRestRoom = hasRestRoom;
            this.HasBalcony= hasBalcony;
            this.BedCount = bedCount;
            this.RoomNumber = roomNumber;
            this.Extras = extras;
            this.Price = price;
        }

        public Room()
        {
            // TODO: Complete member initialization
        }

        
        #region IReservable Members

        public void addReservation(Reservation resr)
        {

            this.Reservations.Add(resr);
        }

        public void removeReservation(Reservation resr)
        {
            this.Reservations.Remove(resr);
        }

        #endregion

        public bool IsReserverdRoom(DateTime startDate, DateTime endDate )
        { 
          foreach (var rs in this.Reservations)
            {
                if (rs.StartDate == startDate &&
                    rs.EndDate == endDate)
                {
                    return false;
                }
            }

          return true;
        }


        public virtual string GetTypeOfRoom()
        {
            return GetType().Name;
        }
        public override string ToString()
        {
            StringBuilder  reserv = new StringBuilder();
            foreach (var r in this.Reservations)
	        {
                reserv.Append("StartDate: ");
                reserv.Append(r.StartDate);
                reserv.Append(" EndDate: ");
                reserv.Append(r.EndDate);
                reserv.Append(" Guest");
                reserv.Append(r.Guest.ToString());
	        }

            if (reserv.Length == 0)
            {
                reserv.Append("status free !");
            }
            string extras = "";
            foreach (var e in this.Extras)
	        {
		        extras+= e + " ";
	        }                

            StringBuilder strRoom = new StringBuilder();
            strRoom.Append(this.RoomNumber);
            strRoom.Append("; Room type: ");
            strRoom.Append(this.RoomType);
            if (this.HasBalcony)
            {
                strRoom.Append("; Room balcony: YES!");
            }
            else
            {
                strRoom.Append("; Room balcony: NO!");
            }

            if (this.HasRestRoom)
            {
                strRoom.Append("; Rest room: YES!");
            }
            else
            {
                strRoom.Append("; Rest room: NO!");
            }
            strRoom.Append("; Extras(");
            strRoom.Append(extras+ ")");
            strRoom.Append("\nPrice:");
            strRoom.Append(String.Format("{0:0.00##}",this.Price));

            Console.WriteLine();
            return String.Format("{2} No:{0} \nReservation: {1}", strRoom.ToString(), reserv.ToString(), this.GetType().Name);
        }
    }
}
