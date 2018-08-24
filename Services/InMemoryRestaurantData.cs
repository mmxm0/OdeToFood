using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        

        public InMemoryRestaurantData()
        {
            this._restaurantes = new List<Restaurante>
            {
                new Restaurante  { Id = 1, Nome = "Bk Abdias de Carvalho" },
                new Restaurante  { Id = 2, Nome = "Bk Torre"},
                new Restaurante  { Id = 3, Nome= "Bk Shopping Rio Mar"}

            };
        }

        public IEnumerable<Restaurante> GetAll()
        {
           return _restaurantes.OrderBy(r => r.Nome);
        }

        public Restaurante Get(int id)
        {
            return _restaurantes.FirstOrDefault(r => r.Id == id);
        }

        public Restaurante Add(Restaurante restaurante)
        {
            restaurante.Id = _restaurantes.Max(r => r.Id) + 1;
            _restaurantes.Add(restaurante);
            return restaurante;

        }

        List<Restaurante> _restaurantes;
    }
}
