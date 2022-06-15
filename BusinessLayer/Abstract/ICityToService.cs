using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICityToService : IGenericService<CityTo>
    {
        List<CityTo> GetSearchedCityTos(CityTo cityTo);
    }
}
