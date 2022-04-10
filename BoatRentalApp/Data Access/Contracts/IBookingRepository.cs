using BoatRentalApp.Entities;
using System.Collections.Generic;

namespace BoatRentalApp.DataAccess.Contracts
{
    public interface IBookingRepository
    {
        Client GetBookings(int bookingNumber);
    }
}
