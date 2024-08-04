using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    public required string BookingId { get; set; }
    public required string UserId { get; set; }
    public required string DestId { get; set; }
    public required string DestinationName { get; set; }
    public required DateOnly CheckInDate { get; set; }
    public required DateOnly CheckOutDate { get; set; }
    public required int NoOfPersons { get; set; }
    public decimal TotalCharges { get; set; }
    public DateTime TimeStamp { get; set; }
}