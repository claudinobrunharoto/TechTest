namespace Domain
{
    public class Vehicle
    {
        protected int _maxPassengers;
        public bool IsRunning { get; private set; }
        public void Start(List<Person> passengers)
        {
            if (passengers.Count() > _maxPassengers)
            {
                throw new Exception("Too many passengers (max = " + _maxPassengers + ")");
            }

            IsRunning = true;
        }
    }

    public class Car : Vehicle
    {
        public Car() { _maxPassengers = 4; }
    }

    public class MotorBike : Vehicle
    {
        public MotorBike() { _maxPassengers = 2; }
    }

    public class Coach : Vehicle
    {
        public Coach() { _maxPassengers = 25; }
    }

    public class Person
    {
        public static List<Person> CreateList(int number)
        {
            var people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                people.Add(new Person());
            }

            return people;
        }
    }
}