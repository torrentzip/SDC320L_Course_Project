// Torren Moore
// Date: 11/17/2026
// SDC320L Course Project - Week 1 Demo
// File: ContactInfo.cs
// Purpose: ContactInfo stores an employee's phone, email, and city. It is
//          used for composition because every Employee contains a ContactInfo.

using System;

/// <summary>
/// ContactInfo is a small helper class used for COMPOSITION.
/// Every Employee "has a" ContactInfo object inside it.
/// </summary>
public class ContactInfo
{
    // Private fields: only this class can touch them directly
    private string phone;
    private string email;
    private string city;

    // Constructor: sets up a new ContactInfo object
    public ContactInfo(string phone, string email, string city)
    {
        this.phone = phone;
        this.email = email;
        this.city = city;
    }

    // Public properties: controlled access to the private fields
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    // Text shown whenever the contact info is printed
    public override string ToString()
    {
        return phone + " | " + email + " | " + city;
    }
}
