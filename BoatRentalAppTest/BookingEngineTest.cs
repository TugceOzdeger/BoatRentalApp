using BoatRentalApp.BusinessLogic;
using BoatRentalApp.Enums;
using Xunit;

namespace BoatRentalAppTest
{
    public class BookingEngineTest
    {
        [Fact]
        public void Test_Create_A_Booking()
        {
            //Arrange
            var socialSecurityNumber = "19000101-1234";
            var boatNumber = 1;
            var boatCategory = BoatCategoryEnum.Jolle;

            //Act
            var bookingEngine = new BookingEngine();
            var bookingNumber = bookingEngine.RentBoat(socialSecurityNumber, boatNumber, boatCategory);

            //Assert
            Assert.True(bookingNumber > 0 && bookingNumber < 100 );
        }

        [Fact]
        public void Test_Get_Data()
        {
            //Arrange
            var socialSecurityNumber = "19000101-1234";
            var boatNumber = 1;
            var boatCategory = BoatCategoryEnum.Jolle;

            //Act
            var bookingEngine = new BookingEngine();
            var client = bookingEngine.GetClient(socialSecurityNumber);
            var boat = bookingEngine.GetBoat(boatNumber, boatCategory);

            //Assert
            Assert.NotNull(client);
            Assert.NotNull(boat);
            Assert.Equal(socialSecurityNumber, client.SocialSecurityNumber);
            Assert.Equal(boatNumber, boat.Number);
        }
    }
}
