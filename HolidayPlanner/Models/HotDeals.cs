using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class HotDeals{
    public required string DestinationId { get; set; }
    public required string Continent { get; set; }
    public required string ImageUrl { get; set; }
    public required string Name { get; set; }
    public decimal NoOfNights { get; set; }
    public decimal FlightCharges { get; set; }
    public decimal ChargesPerPerson { get; set; }
    public decimal Discount { get; set; }
    public int availability { get; set; }
}