using Domain.Enums;

namespace Application.AppModel
{
    public class PackageAppModel
    {
        public int Id { get; set; }
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public string CarrierLogoUrl { get; set; }
        public string PhotoUrl { get; set; }
        public string? ConfirmationPhotoUrl { get; set; }
    }
}
