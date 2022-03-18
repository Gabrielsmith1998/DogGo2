using DogGo2.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo2.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        void AddDog(Dog dog);
        void UpdateDog(Dog dog);
        void DeleteDog(int id);
    }
}
