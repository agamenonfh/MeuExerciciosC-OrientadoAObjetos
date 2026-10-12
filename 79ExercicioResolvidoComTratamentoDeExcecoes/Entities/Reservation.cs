using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Exceptions;

namespace Course.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out must be a date after check-in."); // o 'throw' corta o codigo.
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("The dates must be further the today.");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out must be a date after check-in.");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }
        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in {CheckIn.ToString("dd/MM/yyyy")}, check-out {CheckOut.ToString("dd/MM/yyyy")}, duration {Duration()} night(s).";
        }
    }
}
