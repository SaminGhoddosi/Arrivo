namespace Domain.Entities
{
    public class Package : Entity
    {
        public int CarrierId { get; set; }
        public Carrier Carrier { get; set; }
    }
}
