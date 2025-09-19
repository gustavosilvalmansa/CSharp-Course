using System;
using Reservation.Entities.Exceptions;

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
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            this.roomNumber = roomNumber;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            this.checkIn = checkIn;
            this.checkOut = checkOut;


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
