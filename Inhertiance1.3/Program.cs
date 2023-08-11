using System;

class Human
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Gender: {Gender}";
    }
}

class Employee : Human
{
    public int EmployeeId { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}, EmployeeId: {EmployeeId}, Department: {Department}, Salary: {Salary:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Human h1 = new Human
        {
            Name = "Sara Ramadan",
            Age = 21,
            Gender = "Female"
        };

        Employee employee = new Employee
        {
            Name = "Hager Ramadan",
            Age = 17,
            Gender = "Female",
            EmployeeId = 2,
            Department = "IT",
            Salary = 50000.00
        };

        Console.WriteLine(h1);
        Console.WriteLine(employee);

        Console.ReadLine();
    }
}