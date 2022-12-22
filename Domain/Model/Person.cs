namespace Domain.Model;

using Domain.Interface;
using System.Collections.Generic;

public class Person : IPerson
{
    public static List<IPerson> CreateList(int number)
    {
        var people = new List<IPerson>();

        for (int i = 0; i < number; i++)
        {
            people.Add(new Person());
        }

        return people;
    }
}
