namespace Domain.Base;
using Domain.Interface;

public abstract class Vehicle : IVehicle
{
    protected int _maxPassengers = 0;

    protected List<IPerson> _passengers = new();

    public bool IsRunning { get; private set; }

    public void AddPassenger(IPerson person)
    {
        if (_passengers.Count() >= _maxPassengers)
        {
            throw new Exception("Too many passengers (max = " + _maxPassengers + ")");
        }

        _passengers.Add(person);
    }

    public void AddPassengers(List<IPerson> people)
    {
        foreach (IPerson person in people)
        {
            AddPassenger(person);
        }
    }

    public void Start()
    {
        IsRunning = true;
    }
}