using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CityFrom
    {
        public int CityFromId { get; set; }
        public string Name { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
