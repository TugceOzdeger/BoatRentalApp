using BoatRentalApp.DataAccess.Data;
using BoatRentalApp.Enums;
using System;

namespace BoatRentalApp.BusinessLogic
{
    public class BoatEngine
    {
        private const decimal baseFee = 100m;
        private const decimal hourPrice = 50m;

        public void ReturnBoat(int boatNumber, DateTime rentDate, out decimal cost)
        {
            var boatCategory = ValidateBoatNumber(boatNumber);

            if (boatCategory == BoatCategoryEnum.None) 
                Console.WriteLine("No boat found for given boat number: " + boatNumber);

            int hours = CalculateHours(rentDate);
            cost = CalculateRentalCost(boatCategory, hours);
            Console.WriteLine("You rental cost is " + CalculateRentalCost(boatCategory, hours));

            Console.WriteLine();
        }

        public decimal CalculateRentalCost(BoatCategoryEnum boatCategory, int duration)
        {
            if (boatCategory == BoatCategoryEnum.Jolle)
                return baseFee + (hourPrice * duration);
            else if (boatCategory == BoatCategoryEnum.BoatSmall)
                return (baseFee * 1.2m) + (1.3m * hourPrice * duration);
            else if (boatCategory == BoatCategoryEnum.BoatLarge)
                return (baseFee * 1.5m) + (1.4m * hourPrice * duration);
            return decimal.Zero;
        }

        public int CalculateHours(DateTime rentDate)
        {
            var duration = DateTime.Now - rentDate;

            if (duration.Minutes > 0)
                return duration.Hours + 1;
            else return duration.Hours;
        }

        public BoatCategoryEnum ValidateBoatNumber(int boatNumber)
        {
            var repo = new BoatRepository();
            return repo.ValidateBoatNumber(boatNumber);
        }
    }
}
