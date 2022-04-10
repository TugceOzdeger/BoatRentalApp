using BoatRentalApp.DataAccess.Data;
using BoatRentalApp.Entities;
using BoatRentalApp.Enums;
using System;

namespace BoatRentalApp.BusinessLogic
{
    public class BookingEngine
    {
        public int RentBoat(string socialSecurityNumber, int boatNumber, BoatCategoryEnum boatCategory)
        {
            var newBooking = new Booking
            {
                Id = Guid.NewGuid(),
                Number = new Random().Next(0,100),
                Boat = GetBoat(boatNumber, boatCategory),
                Client = GetClient(socialSecurityNumber),
                BookingDate = DateTime.Now
            };

            return newBooking.Number;
        }

        public Client GetClient(string socialSecurityNumber)
        {
            var repo = new ClientRepository();
            return repo.GetClient(socialSecurityNumber);
        }

        public Boat GetBoat(int boatNumber, BoatCategoryEnum boatCategory)
        {
            var repo = new BoatRepository();
            return repo.GetBoat(boatNumber, boatCategory);
        }
    }
}
