// Torren Moore
// Date: 11/17/2026
// SDC320L Course Project - Week 1 Demo
// File: ShopManager.cs
// Purpose: ShopManager is a salaried employee. It demonstrates inheritance by
//          deriving from Employee.

using System;

/// <summary>
/// ShopManager is a SALARIED employee. It inherits from Employee.
/// </summary>
public class ShopManager : Employee
{
    private decimal annualSalary;

    // Constructor: passes the shared values up to the Employee constructor
    public ShopManager(int id, string firstName, string lastName,
        ContactInfo contact, decimal annualSalary)
        : base(id, firstName, lastName, contact)
    {
        this.annualSalary = annualSalary;
    }

    public decimal AnnualSalary
    {
        get { return annualSalary; }
        set { annualSalary = value; }
    }

    public override string EmployeeType
    {
        get { return "Salaried"; }
    }

    // Salaried pay: the yearly salary split into 52 weeks
    public override decimal CalculateWeeklyPay()
    {
        return annualSalary / 52;
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine
            + "    Annual salary: " + annualSalary.ToString("C");
    }
}
