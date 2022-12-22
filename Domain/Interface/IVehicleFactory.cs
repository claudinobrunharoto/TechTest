namespace Domain.Interface;

using Domain.Enum;

public interface IVehicleFactory
{
    IVehicle CreateVehicle(VehicleType vehicleType);
}
