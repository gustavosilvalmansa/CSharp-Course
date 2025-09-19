using System;


namespace Reservation.Entities
{
    class ReservationClass
    {
        public int roomNumber { get; set; }

        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public ReservationClass()
        {
        }

        public ReservationClass(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            this.roomNumber = roomNumber;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room "
                + roomNumber
                + ", check-in: "
                + checkIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + checkOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }


    }
}
