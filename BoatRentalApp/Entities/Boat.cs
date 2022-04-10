using BoatRentalApp.Enums;
using System;

namespace BoatRentalApp.Entities
{
    public class Boat
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public BoatCategoryEnum BoatCategory { get; set; }
    }
}
