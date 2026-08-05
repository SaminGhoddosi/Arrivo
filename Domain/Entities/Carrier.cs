using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Carrier : Entity
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public CreatedEnum CreatedBy { get; set; }
    }
    public enum CreatedEnum
    {
        System,
        AI
    }
}
