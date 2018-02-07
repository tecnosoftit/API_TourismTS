using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.General
{
    public class Plans
    {
        public int IDENTIFICATION { get; set; }
        public string NAMES { get; set; }
        public string DESCRIPTIONS { get; set; }
        public bool STATUS_ { get; set; }
        public int TYPE_ { get; set; }
        public string TYPE_NAME_ { get; set; }
        public DateTime CREATION { get; set; }
        public DateTime MODIFICATION { get; set; }
    }
}
