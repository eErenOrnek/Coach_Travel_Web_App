using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        List<Destination> GetDestinationsBySearch(int cityFromId, int cityToId);
        List<Destination> GetDestinationsWithCities();
    }
}
