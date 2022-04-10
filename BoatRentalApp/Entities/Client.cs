using System;

namespace BoatRentalApp.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}
