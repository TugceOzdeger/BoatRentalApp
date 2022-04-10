using BoatRentalApp.BusinessLogic;
using BoatRentalApp.Enums;
using System;
using Xunit;

namespace BoatRentalAppTest
{
    public class BoatEngineTest
    {
        [Fact]
        public void Test_Calculate_Rental_Hours()
        {
            //Arrange
            var rentalDate1 = DateTime.Now.AddMinutes(-35);
            var rentalDate2 = DateTime.Now.AddMinutes(-132);
            var rentalDate3 = DateTime.Now.AddMinutes(-180);

            //Act
            var boatEngine = new BoatEngine();
            var duration1 = boatEngine.CalculateHours(rentalDate1);
            var duration2 = boatEngine.CalculateHours(rentalDate2);
            var duration3 = boatEngine.CalculateHours(rentalDate3);

            //Assert
            Assert.Equal(1, duration1);
            Assert.Equal(3, duration2);
            Assert.Equal(3, duration3);
        }

        [Fact]
        public void Test_Calculate_Rental_Cost()
        {
            //Act
            var boatEngine = new BoatEngine();

            var cost1 = boatEngine.CalculateRentalCost(BoatCategoryEnum.Jolle, 1);
            var cost2 = boatEngine.CalculateRentalCost(BoatCategoryEnum.BoatSmall, 3);
            var cost3 = boatEngine.CalculateRentalCost(BoatCategoryEnum.BoatLarge, 3);

            //Assert
            Assert.Equal(150, cost1);
            Assert.Equal(315, cost2);
            Assert.Equal(360, cost3);
        }

        [Fact]
        public void Test_Return_BoatCategory_When_Boat_Number_Is_Available()
        {
            //Act
            var boatEngine = new BoatEngine();

            var category1 = boatEngine.ValidateBoatNumber(1);
            var category2 = boatEngine.ValidateBoatNumber(2);
            var category3 = boatEngine.ValidateBoatNumber(3);
            var category4 = boatEngine.ValidateBoatNumber(4);

            //Assert
            Assert.Equal(BoatCategoryEnum.Jolle, category1);
            Assert.Equal(BoatCategoryEnum.BoatLarge, category2);
            Assert.Equal(BoatCategoryEnum.BoatSmall, category3);
            Assert.Equal(BoatCategoryEnum.None, category4);
        }

        [Fact]
        public void Test_Return_Boat_When()
        {
            //Arrange
            var rentalDate = DateTime.Now.AddMinutes(-35);
            var boatNumber = 1;
            var cost = decimal.Zero;

            //Act
            var boatEngine = new BoatEngine();
            boatEngine.ReturnBoat(boatNumber, rentalDate, out cost);

            //Assert
            Assert.Equal(150, cost);
        }
    }
}
