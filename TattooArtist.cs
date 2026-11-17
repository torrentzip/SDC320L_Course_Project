// Torren Moore
// Date: 11/17/2026
// SDC320L Course Project - Week 1 Demo
// File: TattooArtist.cs
// Purpose: TattooArtist is a commission employee. It demonstrates inheritance
//          by deriving from Employee.

using System;

/// <summary>
/// TattooArtist is a COMMISSION employee. It inherits from Employee.
/// </summary>
public class TattooArtist : Employee
{
    private decimal weeklySales;
    private decimal commissionRate; // for example 0.60 means the artist keeps 60%

    public TattooArtist(int id, string firstName, string lastName,
        ContactInfo contact, decimal weeklySales, decimal commissionRate)
        : base(id, firstName, lastName, contact)
    {
        this.weeklySales = weeklySales;
        this.commissionRate = commissionRate;
    }

    public decimal WeeklySales
    {
        get { return weeklySales; }
        set { weeklySales = value; }
    }

    public decimal CommissionRate
    {
        get { return commissionRate; }
        set { commissionRate = value; }
    }

    public override string EmployeeType
    {
        get { return "Commission"; }
    }

    // Commission pay: a percentage of the week's sales
    public override decimal CalculateWeeklyPay()
    {
        return weeklySales * commissionRate;
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine
            + "    Weekly sales: " + weeklySales.ToString("C")
            + ", Commission rate: " + (commissionRate * 100) + "%";
    }
}
