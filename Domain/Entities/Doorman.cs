using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doorman : Person
    {
        public Person Person { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
