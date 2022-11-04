using Riok.Mapperly.Abstractions;

namespace ConsoleApp59;

[Mapper]
public partial class CarMapper
{
    public partial CarDto CarToCarDto(Car car);
}