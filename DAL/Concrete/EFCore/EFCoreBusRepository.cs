using DAL.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreBusRepository : EFCoreGenericRepository<Bus, Context>, IBusRepository
    {
    }
}
