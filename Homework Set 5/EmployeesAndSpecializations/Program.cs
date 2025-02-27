// Written By: Patrick Leonard
// 2/26/2025

using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace EmployeesAndSpecializations;

public class Program
{
    static void Main(string[] args)
    {
        Manager manager = new("Michael Scott", new Decimal(420.69), 30);
        Engineer engineer = new("Dingus", new decimal(50000.60), "Electrical");

        Console.WriteLine(manager);
        Console.WriteLine(engineer);
    }
}

public class Employee
{
    // Backing Fields
    private string name = "n/a";
    private decimal salary = -1;

    // Gets and Sets
    public string Name
    {
        get => name;
        set => name = value;
    }

    public decimal Salary
    {
        get => salary;
        set => salary = value;
    }

    // Constructors
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    // Methods
    public override string ToString()
    {
        return $"Employee: {Name}, Salary: ${Salary}";
    }
}

public class Manager : Employee
{
    // Backing Fields
    private int numUnderlings = -1;

    // Gets and Sets
    public int NumberOfEmployeesManaged
    {
        get => numUnderlings;
        set => numUnderlings = value;
    }

    // Constructors
    public Manager(string name, decimal salary, int numEmployees) : base(name, salary)
    {
        NumberOfEmployeesManaged = numEmployees;
    }

    // Methods
    public override string ToString()
    {
        return $"Manager - {Name}, Salary: ${Salary}, Number of Managed Employees: {NumberOfEmployeesManaged}";
    }
}

public class Engineer : Employee
{
    // Backing Fields
    private string specialization = "n/a";

    // Gets and Sets
    public string Specialization
    {
        get => specialization;
        set => specialization = value;
    }

    // Constructors
    public Engineer(string name, decimal salary, string specialization) : base(name, salary)
    {
        Specialization = specialization;
    }

    // Methods
    public override string ToString()
    {
        return $"Engineer - {Name}, Salary: ${Salary}, Specialization: {Specialization}";
    }
}