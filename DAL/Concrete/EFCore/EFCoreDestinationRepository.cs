using DAL.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreDestinationRepository : EFCoreGenericRepository<Destination, Context>, IDestinationRepository
    {
        public List<Destination> GetDestinationsBySearch(int cityFromId, int cityToId)
        {
            using var context = new Context();
            var destinations = context
                .Destinations
                .Include(x => x.CityTo)
                .Include(x => x.CityFrom)
                .Where(x => x.CityFrom.CityFromId == cityFromId && x.CityTo.CityToId == cityToId)
                .ToList();
            return destinations;
        }

        public List<Destination> GetDestinationsWithCities()
        {
            using var context = new Context();
            var destinations = context
                .Destinations
                .Include(dest => dest.CityFrom)
                .Include(dest => dest.CityTo)
                .ToList();
            return destinations;
        }
    }
}
