using BusinessLayer.Abstract;
using DAL.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityToManager : ICityToService
    {
        private readonly ICityToRepository _cityToRepository;

        public CityToManager(ICityToRepository cityToRepository)
        {
            _cityToRepository = cityToRepository;
        }

        public void Create(CityTo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CityTo entity)
        {
            throw new NotImplementedException();
        }

        public List<CityTo> GetAll()
        {
            return _cityToRepository.GetAll();
        }

        public CityTo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CityTo> GetSearchedCityTos(CityTo cityTo)
        {
            return _cityToRepository.GetSearchedCityTos(cityTo);
        }

        public void Update(CityTo entity)
        {
            throw new NotImplementedException();
        }
    }
}
