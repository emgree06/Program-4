// Program 4
// CIS 200-01
// Due: 4/15/2018
// By: Z9435

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy using
// LINQ and demonstrates polymorphism.
// This file also demonstrates the IComparable interface by sorting the items in default and using DescOrder sort.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
        
        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

    

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMovie("Men In Black", "Lions Gate", 1990, 10,
            "MO99 4S", 120.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMovie("Zootopia", "Pixar", 2016, 10,
            "MO98 4S", 130.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryJournal("Clinical Medicine", "Royal College of Physicians", 2017, 20,
            "CC4 3F", 1, 7, "Medicine", "Humphrey Hodgson"));
        items.Add(new LibraryJournal("The New England Journal of Medicine", "Massachusetts Medical Society", 2013, 7,
            "AB34 3F", 5, 6, "Medicine", "Jeffrey M. Drazen"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9B", 16, 8));
        items.Add(new LibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14,
            "MA21 5V", 1, 1));


       items.Sort();// sorts the items using the default sort (item ascending order)
        Console.WriteLine("List of items in default sort:\n");
       foreach (LibraryItem item in items)
       Console.WriteLine("{0}\n", item.Title);
      Pause();

        items.Sort(new DescOrder()); // sorts the items by copy right year in descending order
        Console.WriteLine("List of items in descending order by copy right year:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item.CopyrightYear);
        Pause();

        items.Sort(new EC_Sort()); // groups the items by type and then sorts them by title in ascending order
        Console.WriteLine("List of items in separated by type and sorted by ascending order by title:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}, {1}\n", item.GetType(), item.Title);
        Pause();
    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }
}