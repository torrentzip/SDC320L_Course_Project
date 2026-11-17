// Torren Moore
// Date: 11/17/2026
// SDC320L Course Project - Week 1 Demo
// File: Employee.cs
// Purpose: Employee is the abstract base class for all studio employees. It
//          demonstrates inheritance (as the parent class) and composition
//          (it contains a ContactInfo object).

using System;

/// <summary>
/// Employee is the BASE class for every kind of studio employee.
/// It is abstract, so you can't create a plain Employee. You create a
/// ShopManager, Apprentice, or TattooArtist, which all INHERIT from it.
/// It also uses COMPOSITION: an Employee has a ContactInfo object.
/// </summary>
public abstract class Employee
{
    // Private fields
    private int id;
    private string firstName;
    private string lastName;
    private ContactInfo contact; // composition: Employee "has a" ContactInfo

    // Constructor: derived classes call this using ": base(...)"
    public Employee(int id, string firstName, string lastName, ContactInfo contact)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.contact = contact;
    }

    // Public properties
    public int Id
    {
        get { return id; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FullName
    {
        get { return firstName + " " + lastName; }
    }

    public ContactInfo Contact
    {
        get { return contact; }
        set { contact = value; }
    }

    // Each derived class must say what type it is (Salaried, Hourly, Commission)
    public abstract string EmployeeType { get; }

    // Each derived class must work out its own weekly pay
    public abstract decimal CalculateWeeklyPay();

    // Text shown whenever an employee is printed
    public override string ToString()
    {
        return "[" + id + "] " + FullName + " (" + EmployeeType + ")" + Environment.NewLine
            + "    Contact: " + contact + Environment.NewLine
            + "    Weekly pay: " + CalculateWeeklyPay().ToString("C");
    }
}
