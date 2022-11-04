namespace ConsoleApp59;

public class SeatDto
{
    public string Label { get; set; }
    
    public bool IsFront { get; set; }
    
    public bool IsBack { get; set; }
    
    public CarDto ParentCar { get; set; }
}