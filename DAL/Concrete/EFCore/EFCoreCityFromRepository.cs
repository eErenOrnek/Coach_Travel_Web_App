using DAL.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreCityFromRepository : EFCoreGenericRepository<CityFrom, Context>, ICityFromRepository
    {
        public List<CityFrom> GetSearchedCityFroms(CityFrom cityFrom)
        {
            var context = new Context();
            var cities = context
                .CityFroms
                .Where(city => city.Name == cityFrom.Name)
                .ToList();
            return cities;
        }
    }
}
