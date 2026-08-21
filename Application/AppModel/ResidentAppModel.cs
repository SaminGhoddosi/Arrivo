 namespace Application.AppModel
{
     public class ResidentAppModel : PersonAppModel
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public  int ApartmentId { get; set; }
        public int ApartmentNumber { get; set; }
    }
}