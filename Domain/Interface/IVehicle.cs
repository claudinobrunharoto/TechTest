namespace Domain.Interface;
public interface IVehicle
{
    public bool IsRunning { get; }

    public void Start();

    public void AddPassenger(IPerson person);

    public void AddPassengers(List<IPerson> person);
}
