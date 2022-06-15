using DAL.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface ICityFromRepository : IRepository<CityFrom>
    {
        List<CityFrom> GetSearchedCityFroms(CityFrom cityFrom);
    }
}
