using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.General
{
    public class PlanDetail
    {
        public int IDENTIFICATION { get; set; }
        public int PLAN_IDENTIFICATION { get; set; }
        public string PLAN_NAME { get; set; }
        public int ACOMODATION_TYPE { get; set; }
        public string PRICE { get; set; }
        public string INCLUDED { get; set; }
        public string NOT_INCLUDED { get; set; }
        public string TEVELER_INFO { get; set; }
        public string POLICIES { get; set; }
        public string CONDITIONS { get; set; }
        public DateTime CREATION { get; set; }
        public DateTime MODIFICATION { get; set; }
    }
}
