using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Building : Entity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
