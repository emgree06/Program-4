// Program 4
// CIS 200-01
// Due: 4/18/2018
// By: Z9435

// File: DescOrder.cs
// This file extends the IComparable interface by using Comparer to compare 
//  two library items and overloading the CompareTo method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class DescOrder : Comparer<LibraryItem> //extneding the IComparable interface with
                                            // comparer. Using it to compare two library items'
                                            // Copy right year and overriding the sort to sort the items
                                            // in descending order by copy right year.
    {
        //Precondition: are two library items to compare
        //Postcondition: The library items have been sorted in descending order by copy right year
        public override int Compare(LibraryItem x, LibraryItem y)
                                                               
        {
                if (x == null && y == null) // both null
                    return 0;                 

                if (x == null) // only x null
                    return -1;  

                if (y == null) // only y is null
                    return 1;

                if (x.CopyrightYear.CompareTo(y.CopyrightYear) != 0)
                {
                    return (-1) * x.CopyrightYear.CompareTo(y.CopyrightYear); // reverse the sort
                }
                else
                    return  0;
        }
    }
}
