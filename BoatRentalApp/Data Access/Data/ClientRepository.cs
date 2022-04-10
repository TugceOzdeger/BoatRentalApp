using BoatRentalApp.DataAccess.Contracts;
using BoatRentalApp.Entities;
using System;
using System.Collections.Generic;

namespace BoatRentalApp.DataAccess.Data
{
    public class ClientRepository : IClientRepository
    {
        public Client GetClient(string socialSecurityNumber)
        {
            return  MockClientData().Find(x => x.SocialSecurityNumber == socialSecurityNumber);
        }

        public List<Client> MockClientData()
        {
            return new List<Client>
            {
                new Client
                {
                    Id = Guid.NewGuid(),
                    Name = "XXXX",
                    Surname = "YYYY",
                    SocialSecurityNumber = "19000101-1234"
                }
            };
        }
    }
}
