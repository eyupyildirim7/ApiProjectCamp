namespace ApiProjeKampi.WepApi.Entities
{
    public class Rezarvation
    {
        public int RezarvationId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RezarvationDate { get; set; }
        public string RezarvationTime { get; set; }
        public int CountOfPeople { get; set; }
        public string Message { get; set; }
        public string RezarvationStatus { get; set; }
    }
}
