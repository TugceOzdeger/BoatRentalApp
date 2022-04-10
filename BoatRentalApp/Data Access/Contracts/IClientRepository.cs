using BoatRentalApp.Entities;
using System.Collections.Generic;

namespace BoatRentalApp.DataAccess.Contracts
{
    public interface IClientRepository
    {
        Client GetClient(string socialSecurityNumber);

        public List<Client> MockClientData();
    }
}
