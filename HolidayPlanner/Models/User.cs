using System.Numerics;

public class User
{
    public required string UserId { get; set; }
    public required string Name { get; set; }
    public required string EmailId { get; set; }
    public long ContactNo { get; set; }
    public required string Password { get; set; }
    public List<Booking>? Booking { get; set; }
}