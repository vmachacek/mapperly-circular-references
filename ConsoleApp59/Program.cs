// See https://aka.ms/new-console-template for more information

using ConsoleApp59;

var mapper = new CarMapper();
var car = new Car
{
    NumberOfSeats = 10, Seats = 1, SeatsForReal = new[]
    {
        new Seat()
        {
            Label = "yolo",
            IsBack = false,
            IsFront = true,
        },
    },
};

foreach (var seat in car.SeatsForReal)
{
    seat.ParentCar = car;
}

car.PrimarySeat = car.SeatsForReal[0];

var dto = mapper.CarToCarDto(car);

Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(dto));