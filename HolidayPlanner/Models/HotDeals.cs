using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class HotDeals{
    [Required]
    public required string DestinationId { get; set; }
    [Required]
    public required string Continent { get; set; }
    [Required]
    public required string ImageUrl { get; set; }
    [Required]
    public required string Name { get; set; }
    [Range(1, 30)]
    public decimal NoOfNights { get; set; }
    [Range(0, double.MaxValue)]
    public decimal FlightCharges { get; set; }
    [Range(0, double.MaxValue)]
    public decimal ChargesPerPerson { get; set; }
    [Range(0, 100)]
    public decimal Discount { get; set; }
    [Range(0, int.MaxValue)]
    public int availability { get; set; }
}