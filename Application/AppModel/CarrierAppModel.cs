using Domain.Entities;

namespace Application.AppModel
{
    public class CarrierAppModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public CreatedEnum CreatedBy { get; set; }
    }
}
