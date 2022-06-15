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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepository;

        public DestinationManager(IDestinationRepository destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public void Create(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public List<Destination> GetAll()
        {
            return _destinationRepository.GetAll();
        }

        public Destination GetById(int id)
        {
            return _destinationRepository.GetById(id);
        }

        public List<Destination> GetDestinationsBySearch(int cityFromId, int cityToId)
        {
            return _destinationRepository.GetDestinationsBySearch(cityFromId, cityToId);
        }

        public List<Destination> GetDestinationsWithCities()
        {
            return _destinationRepository.GetDestinationsWithCities();
        }

        public void Update(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
