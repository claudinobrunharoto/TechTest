namespace WebApi.Dto;

using Domain.Enum;

public class AddPassengerToVehicleDto
{
    public VehicleType VehicleType { get; set; } = VehicleType.Unknown;
    public int Quantity { get; set; }
}
