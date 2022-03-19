using DogGo2.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo2.Repositories
{
    public interface IWalksRepository
    {
        List<Walks> GetAllWalks();
        List<Walks> GetWalksByWalkerId(int walkerId);
    }
}