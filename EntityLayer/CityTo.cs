using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class CityTo
    {
        public int CityToId { get; set; }
        public string Name { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
