using System;
using System.Collections.Generic;

// Base abstract class for all employees
abstract class Employee
{
    public string FirstName { get; set; }  // Ad
    public string LastName { get; set; }   // Soyad
    public string Department { get; set; } // Departman

    // Abstract method that each employee must implement
    public abstract void Duty();  // Soyut metod: Her çalışan kendi görevini bu metodda açıklar
}

// Developer class inherits from Employee
class Developer : Employee
{
    public override void Duty()
    {
        Console.WriteLine("I am working as a Developer."); // Yazılım geliştiricisi olarak çalışıyorum.
    }
}

// Project Manager class inherits from Employee
class ProjectManager : Employee
{
    public override void Duty()
    {
        Console.WriteLine("I am working as a Project Manager."); // Proje yöneticisi olarak çalışıyorum.
    }
}

// Sales Representative class inherits from Employee
class SalesRepresentative : Employee
{
    public override void Duty()
    {
        Console.WriteLine("I am working as a Sales Representative."); // Satış temsilcisi olarak çalışıyorum.
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Developer { FirstName = "Kevser", LastName = "Tekyiğit", Department = "IT" },
            new ProjectManager { FirstName = "Yiğit", LastName = "Tekyiğit", Department = "Management" },
            new SalesRepresentative { FirstName = "Betül", LastName = "Budak", Department = "Sales" }
        };

        // Call the Duty method for each employee
        foreach (var employee in employees)
        {
            Console.Write($"{employee.FirstName} {employee.LastName} from {employee.Department} department: ");
            employee.Duty();  // Her çalışan kendi görevini açıklar
        }
    }
}
