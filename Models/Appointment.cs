namespace AppointmentBooking.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
