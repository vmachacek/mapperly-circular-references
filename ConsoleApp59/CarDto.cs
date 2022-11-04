namespace ConsoleApp59;

public class CarDto
{
    public int Seats { get; set; }
    public int NumberOfSeats { get; set; }
    
    public SeatDto[] SeatsForReal { get; set; }
    
    public Seat PrimarySeat { get; set; }
}