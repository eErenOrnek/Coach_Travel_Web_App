using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Models
{
    public class CityModel
    {
        public List<CityFrom> CitiesFrom { get; set; }
        public List<CityTo> CitiesTo { get; set; }
        public DateTime Q { get; set; }
    }
}
