namespace ConsoleApp59;

public class Seat
{
    public string Label { get; set; }
    
    public bool IsFront { get; set; }
    
    public bool IsBack { get; set; }
    
    public Car ParentCar { get; set; }
}