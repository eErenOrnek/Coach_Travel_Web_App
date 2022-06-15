using DAL.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreCityToRepository : EFCoreGenericRepository<CityTo, Context>, ICityToRepository
    {
        public List<CityTo> GetSearchedCityTos(CityTo cityTo)
        {
            var context = new Context();
            var cities = context
                .CityTos
                .Where(city => city.Name == cityTo.Name)
                .ToList();
            return cities;
        }
    }
}
