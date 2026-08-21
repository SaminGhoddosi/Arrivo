namespace Application.AppModel
{
     public class ResidentAppModel : PersonAppModel
    {
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public  int ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
    }
}