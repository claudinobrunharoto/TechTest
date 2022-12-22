namespace WebApi.Factory;

using Domain.Enum;
using Domain.Interface;
using Domain.Model;

public class VehicleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle(VehicleType vehicleType) =>
        vehicleType switch
        {
            VehicleType.Car => new Car(),
            VehicleType.Coach => new Coach(),
            VehicleType.MotorBike => new MotorBike(),
            _ => throw new ArgumentException("Unsupported vehicle type.")
        };
}
