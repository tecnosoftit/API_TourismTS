using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.General
{
    public class Menu
    {
        public int MEN_ID { get; set; }
        public string MEN_NAME { get; set; }
        public string MEN_CONTROLLER { get; set; }
        public string MEN_VIEW { get; set; }
        public bool MEN_ISPARENT { get; set; }
        public int MEN_PARENTID { get; set; }
        public bool MEN_ACTIVE { get; set; }
        public string MEN_ROLE { get; set; }
    }
}
