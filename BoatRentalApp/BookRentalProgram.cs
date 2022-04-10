using BoatRentalApp.BusinessLogic;
using BoatRentalApp.Enums;
using System;

namespace BoatRentalApp
{
    public class BookRentalProgram
    {
        public static void Main()
        {
            var booking = new BookingEngine();

            Console.WriteLine("Enter client's social security number: ");
            var socialSecurityNumber = Console.ReadLine();
            Console.WriteLine("Enter boat number to rent: ");
            var boatNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter boat category to rent: ");
            Console.WriteLine("1 for Jolle 2 for BoatSmall 3 for BoatLarge");
            var category = (BoatCategoryEnum)Convert.ToInt32(Console.ReadLine());
            var bookingNumber = booking.RentBoat(socialSecurityNumber, boatNumber, category);
            Console.WriteLine("You have successfully rented boat number " + boatNumber + " with booking number: " + bookingNumber);

            var boat = new BoatEngine();
            Console.WriteLine("Enter boat number to return: ");
            boatNumber = Convert.ToInt32(Console.ReadLine());
            boat.ReturnBoat(boatNumber, DateTime.Now, out _);
        }
    }
}
