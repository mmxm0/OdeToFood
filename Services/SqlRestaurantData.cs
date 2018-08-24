using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Data;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class SqlRestaurantData : IRestaurantData

    {
        private OdeToFoodDbContext _context;

        public SqlRestaurantData(OdeToFoodDbContext context)
        {
            _context = context;
        }
        public Restaurante Add(Restaurante restaurante)
        {
            _context.Restaurantes.Add(restaurante);
            _context.SaveChanges();
            return restaurante;
        }

        public Restaurante Get(int id)
        {
            return _context.Restaurantes.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurante> GetAll()
        {
            return _context.Restaurantes.OrderBy(r => r.Nome);

        }
    }
}
