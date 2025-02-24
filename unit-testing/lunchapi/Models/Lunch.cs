namespace lunchapi.Models;

public record Lunch
{
    public required string name { get; set; }
    public required decimal price { get; set; }
    public required int quantity { get; set; }
}