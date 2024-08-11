using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    [Required]
    public required string BookingId { get; set; }
    [Required]
    public required string UserId { get; set; }
    [Required]
    public required string DestId { get; set; }
    [Required]
    [StringLength(100)]
    public required string DestinationName { get; set; }
    [Required]
    public required DateOnly CheckInDate { get; set; }
    [Required]
    public required DateOnly CheckOutDate { get; set; }
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "No of persons should be greater than 0")]
    public required int NoOfPersons { get; set; }
    [Range(0, double.MaxValue, ErrorMessage = "Total charges must be a possitive value")]
    public decimal TotalCharges { get; set; }
    public DateTime TimeStamp { get; set; }
}