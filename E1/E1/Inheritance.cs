using System.Data.Common;

namespace E1;

public abstract class Person
{
    public virtual string Name { get; set; }
    public bool IsFemale { get; set; }
    public abstract int LunchRate { get; }

    public Person(string name, bool isFemale)
    {
        if (isFemale == true)
        Name = $"خانم {name}";
        else
        Name = $"آقای {name}";
        IsFemale = isFemale;
    }
}

public class Student : Person
{
    public override int LunchRate => 2000;

    public Student(string name, bool isFemale) : base(name, isFemale)
    {
        if (isFemale == true)
        Name = $"خانم {name}";
        else
        Name = $"آقای {name}";
        IsFemale = isFemale;
    }

    #region TODO
    #endregion
}

public class Employee : Person
{
    public override int LunchRate => 5000;

    public Employee(string name, bool isFemale) : base(name, isFemale)
    {
        if (isFemale == true)
        Name = $"خانم {name}";
        else
        Name = $"آقای {name}";
        IsFemale = isFemale;
    }

    public virtual int CalculateSalary(int h)
    {
        return h * 5000;
    }

    #region TODO
    #endregion
}

public class Teacher : Employee
{
    public override int LunchRate => 10000;

    public Teacher(string name, bool isFemale) : base(name, isFemale)
    {
        Name = $"استاد {name}";
        IsFemale = isFemale;
    }

    public override int CalculateSalary(int h)
    { return h * 20000; }
}