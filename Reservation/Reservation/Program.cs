
using Reservation.Entities;
namespace Reservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                return;
            }
            else
            {
                ReservationClass reservation = new ReservationClass(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
        }
    }
}