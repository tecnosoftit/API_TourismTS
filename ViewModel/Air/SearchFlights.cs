using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Air
{
    public class SearchFlights
    {
        public string Airline { get; set; }
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        public int AdultsNumbers { get; set; }
        public int ChildrenNumbers { get; set; }
        public int InfantsNumber { get; set; }
        public string[] InfantAges { get; set; }
        public string AirClass { get; set; }
    }
}
