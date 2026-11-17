// Torren Moore
// Date: 11/17/2026
// SDC320L Course Project - Week 1 Demo
// File: Apprentice.cs
// Purpose: Apprentice is an hourly employee. It demonstrates inheritance by
//          deriving from Employee.

using System;

/// <summary>
/// Apprentice is an HOURLY employee. It inherits from Employee.
/// </summary>
public class Apprentice : Employee
{
    private decimal hourlyRate;
    private decimal hoursWorked;

    public Apprentice(int id, string firstName, string lastName,
        ContactInfo contact, decimal hourlyRate, decimal hoursWorked)
        : base(id, firstName, lastName, contact)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public decimal HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public decimal HoursWorked
    {
        get { return hoursWorked; }
        set { hoursWorked = value; }
    }

    public override string EmployeeType
    {
        get { return "Hourly"; }
    }

    // Hourly pay: time and a half for any hours over 40 in a week
    public override decimal CalculateWeeklyPay()
    {
        if (hoursWorked <= 40)
        {
            return hourlyRate * hoursWorked;
        }
        decimal overtimeHours = hoursWorked - 40;
        return (hourlyRate * 40) + (overtimeHours * hourlyRate * 1.5m);
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine
            + "    Rate: " + hourlyRate.ToString("C") + "/hr, Hours: " + hoursWorked;
    }
}
