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
    public class BusManager : IBusService
    {
        private readonly IBusRepository _busRepository;

        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        public void Create(Bus entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Bus entity)
        {
            throw new NotImplementedException();
        }

        public List<Bus> GetAll()
        {
            return _busRepository.GetAll();
        }

        public Bus GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Bus entity)
        {
            throw new NotImplementedException();
        }
    }
}
