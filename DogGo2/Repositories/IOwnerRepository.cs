using DogGo2.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo2.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        void AddOwner(Owner owner);
        void UpdateOwner(Owner owner);  
        void DeleteOwner(int id);
        Owner GetOwnerByEmail(string email);
    }
}
