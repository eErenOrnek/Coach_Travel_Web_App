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
    public class CityFromManager : ICityFromService
    {
        private readonly ICityFromRepository _cityFromRepository;

        public CityFromManager(ICityFromRepository cityFromRepository)
        {
            _cityFromRepository = cityFromRepository;
        }

        public void Create(CityFrom entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CityFrom entity)
        {
            throw new NotImplementedException();
        }

        public List<CityFrom> GetAll()
        {
            return _cityFromRepository.GetAll();
        }

        public CityFrom GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CityFrom> GetSearchedCityFroms(CityFrom cityFrom)
        {
            return _cityFromRepository.GetSearchedCityFroms(cityFrom);
        }

        public void Update(CityFrom entity)
        {
            throw new NotImplementedException();
        }
    }
}
