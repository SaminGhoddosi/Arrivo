using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resident : Person
    {
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
