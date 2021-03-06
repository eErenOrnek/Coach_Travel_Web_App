using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface ICityToRepository : IRepository<CityTo>
    {
        List<CityTo> GetSearchedCityTos(CityTo cityTo);
    }
}
