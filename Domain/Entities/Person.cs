using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    [NotMapped]
    public class Person : Entity
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int WhatsAppNumber { get; set; }
    }
}
