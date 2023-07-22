using OOPExamPreparation01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamPreparation01.Models
{
    internal class RouteRepository : IRepository<IRoute>
    {
        private List<IRoute> routes;

        public RouteRepository()
        {
            routes = new List<IRoute>();
        }

        public void AddModel(IRoute route)
        {
            routes.Add(route);
        }

        public IRoute FindById(string identifier)
        {
            IRoute route = routes.FirstOrDefault(r => r.RouteId == int.Parse(identifier));
            return route;
        }

        public IReadOnlyCollection<IRoute> GetAll()
        {
            return routes.AsReadOnly();
        }

        public bool RemoveById(string identifier)
        {
            IRoute route = routes.FirstOrDefault(r => r.RouteId == int.Parse(identifier));
            if (route == null)
            {
                return false;
            }
            routes.Remove(route);
            return true;
        }
    }
}
