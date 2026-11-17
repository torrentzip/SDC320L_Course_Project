// Torren Moore
// Date: 11/17/2026
// SDC320L Course Project - Week 1 Demo
// File: Program.cs
// Purpose: Runs the Inkwell Studio Staff Manager demo. It shows a welcome
//          message, creates sample employees, and lets the user display them.
//          It demonstrates INHERITANCE (ShopManager, Apprentice, and
//          TattooArtist all inherit from Employee) and COMPOSITION (each
//          Employee contains a ContactInfo object).

using System;
using System.Collections.Generic;

public class Program
{
    // The list holds every employee as the base type Employee
    private static List<Employee> staff = new List<Employee>();

    public static void Main(string[] args)
    {
        ShowWelcome();
        LoadSampleStaff();

        // Keep running until the user chooses to quit
        bool running = true;
        while (running)
        {
            ShowMenu();
            string choice = (Console.ReadLine() ?? "").Trim();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ShowAllStaff();
                    break;
                case "2":
                    ShowOneEmployee();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Sorry, that is not a menu option. Please try again.");
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for using Inkwell Studio Staff Manager. Goodbye!");
    }

    // Shows the project week, title, name, and basic instructions
    private static void ShowWelcome()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" PROJECT WEEK 1");
        Console.WriteLine(" Inheritance, Composition, and User Interactions");
        Console.WriteLine(" Inkwell Studio Staff Manager");
        Console.WriteLine(" By Torren Moore");
        Console.WriteLine("==================================================");
        Console.WriteLine();
        Console.WriteLine("Welcome to Inkwell Studio! This program keeps track of the");
        Console.WriteLine("people who work at the shop.");
        Console.WriteLine();
        Console.WriteLine("How to use it:");
        Console.WriteLine("  - Type the number of a menu option and press Enter.");
        Console.WriteLine("  - Choose 0 at any time to quit.");
        Console.WriteLine();
    }

    private static void ShowMenu()
    {
        Console.WriteLine("----- MAIN MENU -----");
        Console.WriteLine("1. View all employees");
        Console.WriteLine("2. View one employee by ID");
        Console.WriteLine("0. Quit");
        Console.Write("Enter your choice: ");
    }

    // Creates one employee of each type with realistic information.
    // INHERITANCE: ShopManager, Apprentice, and TattooArtist are all Employees.
    // COMPOSITION: each one is given its own ContactInfo object.
    private static void LoadSampleStaff()
    {
        staff.Add(new ShopManager(
            1, "Dana", "Brooks",
            new ContactInfo("757-555-0101", "dana@inkwell.example", "Norfolk"),
            62400m));

        staff.Add(new Apprentice(
            2, "Marcus", "Reed",
            new ContactInfo("757-555-0102", "marcus@inkwell.example", "Chesapeake"),
            15m, 44m));

        staff.Add(new TattooArtist(
            3, "Priya", "Nair",
            new ContactInfo("757-555-0103", "priya@inkwell.example", "Virginia Beach"),
            2500m, 0.60m));
    }

    // Prints every employee in a table
    private static void ShowAllStaff()
    {
        Console.WriteLine("{0,-4}{1,-18}{2,-12}{3,12}", "ID", "Name", "Type", "Weekly Pay");
        Console.WriteLine(new string('-', 46));
        foreach (Employee e in staff)
        {
            Console.WriteLine("{0,-4}{1,-18}{2,-12}{3,12}",
                e.Id, e.FullName, e.EmployeeType, e.CalculateWeeklyPay().ToString("C"));
        }
    }

    // Asks for an ID and prints that employee's full details
    private static void ShowOneEmployee()
    {
        Console.Write("Enter the employee ID: ");
        string input = (Console.ReadLine() ?? "").Trim();
        Console.WriteLine();

        int id;
        if (!int.TryParse(input, out id))
        {
            Console.WriteLine("Please enter a whole number for the ID.");
            return;
        }

        foreach (Employee e in staff)
        {
            if (e.Id == id)
            {
                // ToString shows the employee's details, including the
                // ContactInfo object that is composed inside the Employee
                Console.WriteLine(e);
                return;
            }
        }

        Console.WriteLine("No employee was found with ID " + id + ".");
    }
}
