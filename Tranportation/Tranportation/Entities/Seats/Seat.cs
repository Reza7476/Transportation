using Tranportation.Entities.Trips;

namespace Tranportation.Entities.Seats;

public class Seat
{
    public int Id { get; set; }
    public string SeatNumber { get; set; }

    public int TripId { get; set; }
    public Trip Trip { get; set; }

}
