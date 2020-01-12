using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace restAPI.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
         Guid CityGuid(string cityName);
         Task<IEnumerable<string>> GetCities(string name);
         Task<IEnumerable<City>> GetCitiesObject(string name);
    }
}