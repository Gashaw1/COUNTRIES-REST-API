using CountryBLO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinentsBLO.Models
{
    public class Cotinent
    {
        public string CotinentID { get; set; }
        public string CotinentName { get; set; }
        public int CotinentPopulation { get; set; }
        public List<Country> countries { get; set; }
    }
}
