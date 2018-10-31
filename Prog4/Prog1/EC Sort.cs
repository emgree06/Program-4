// Program 4
// CIS 200-01
// Due: 4/18/2018
// By: Z9435

// File: EC.cs
// This file also creates a sort that separates the objects by type and then 
//sorts them by ascending order for title.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class EC_Sort : IComparer<LibraryItem>
    {
        //Precondition: are two library items to compare
        //Postcondition: The library items have been grouped by type and
        //              sorted in ascending order by title
        public int Compare(LibraryItem x, LibraryItem y)
        {
            if (x == null && y == null) // Both null?
                return 0;                   

            if (x == null) // only x is null?
                return -1;    

            if (y == null) // only y is null?
                return 1;

            int sametype = string.Compare(x.GetType().ToString(), y.GetType().ToString());
            if (sametype != 0)
            {
                return sametype;
            }
            else
            {
                if (x.Title.CompareTo(y.Title) != 0)          // Different Title
                    return x.Title.CompareTo(y.Title);        // Use Title to decide
                else if (x.Publisher.CompareTo(y.Publisher) != 0) // Different Publisher?
                    return x.Publisher.CompareTo(y.Publisher);    // Use Publisher to decide
                else                                            // Down to copyright year
                    return x.CopyrightYear.CompareTo(y.CopyrightYear);
            }
        }
    }
}
