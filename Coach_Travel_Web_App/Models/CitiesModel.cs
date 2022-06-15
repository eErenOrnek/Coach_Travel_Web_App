using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coach_Travel_Web_App.Models
{
    public class CitiesModel
    {
        public List<CityTo> CitiesTo { get; set; }
        public List<CityFrom> CitiesFrom { get; set; }
    }
}
