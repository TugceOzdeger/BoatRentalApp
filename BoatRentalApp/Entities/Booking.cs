using System;

namespace BoatRentalApp.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public Client Client { get; set; }
        public Boat Boat { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
