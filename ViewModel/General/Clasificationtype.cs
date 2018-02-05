using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.General
{
    public class ClasificationType
    {
        public int Cla_Id { get; set; }
        public string Cla_Name { get; set; }
        public string Cla_Description { get; set; }
        public bool Cla_Active { get; set; }
        public DateTime Cla_CreationDate { get; set; }
        public DateTime Cla_ModificationDate { get; set; }
    }
}
