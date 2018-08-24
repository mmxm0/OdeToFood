using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurante> GetAll();
        Restaurante Get(int id);
        Restaurante Add(Restaurante restaurante);
    }
}
