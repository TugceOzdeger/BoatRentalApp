using BoatRentalApp.Entities;
using BoatRentalApp.Enums;
using System.Collections.Generic;

namespace BoatRentalApp.DataAccess.Contracts
{
    public interface IBoatRepository
    {
        Boat GetBoat(int boatNumber, BoatCategoryEnum boatCategory);

        BoatCategoryEnum ValidateBoatNumber(int boatNumber);

        List<Boat> MockBoatData();
        
    }
}
