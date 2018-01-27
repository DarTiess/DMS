using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAL
{
    [Serializable]
   public class Laboratory
    {
        public int LabId { get; set; }
        public string LabNumber { get { return string.Format("Lab#{0},LabId"); } }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public City city { get; set; }
        public List<Analysys> Analisiz { get; set; } = new List<Analysys>();


    }
}
