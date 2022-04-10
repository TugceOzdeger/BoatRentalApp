using BoatRentalApp.DataAccess.Contracts;
using BoatRentalApp.Entities;
using BoatRentalApp.Enums;
using System;
using System.Collections.Generic;

namespace BoatRentalApp.DataAccess.Data
{
    public class BoatRepository : IBoatRepository
    {
        public Boat GetBoat(int boatNumber, BoatCategoryEnum boatCategory)
        {
            return MockBoatData().Find(x => x.Number == boatNumber && x.BoatCategory == boatCategory);
        }

        public BoatCategoryEnum ValidateBoatNumber(int boatNumber)
        {
            var boat =  MockBoatData().Find(x => x.Number == boatNumber);
            return boat != null ? boat.BoatCategory : BoatCategoryEnum.None;
        }

        public List<Boat> MockBoatData()
        {
            return new List<Boat>
            {
                new Boat
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    BoatCategory = BoatCategoryEnum.Jolle
                },

                new Boat
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    BoatCategory = BoatCategoryEnum.BoatLarge
                },
                
                new Boat
                {
                    Id = Guid.NewGuid(),
                    Number = 3,
                    BoatCategory = BoatCategoryEnum.BoatSmall
                }
            };
        }
    }
}
