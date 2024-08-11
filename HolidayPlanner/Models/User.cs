using System.ComponentModel.DataAnnotations;

public class User
{
    [Required]
    public required string UserId { get; set; }
    [Required]
    [StringLength(50)]
    public required string Name { get; set; }
    [Required]
    public required string EmailId { get; set; }
    [Required]
    public long ContactNo { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 8)]
    public required string Password { get; set; }
    public List<Booking>? Booking { get; set; }
}