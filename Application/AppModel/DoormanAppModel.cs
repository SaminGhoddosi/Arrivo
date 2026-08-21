namespace Application.AppModel
{
    public class DoormanAppModel : PersonAppModel
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
    }
}