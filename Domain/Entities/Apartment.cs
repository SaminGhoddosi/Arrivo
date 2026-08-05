using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Apartment : Entity
    {
        public int Number { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
