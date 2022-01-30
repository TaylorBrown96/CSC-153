/**
* 29JAN22
* CSC 153
* Taylor J. Brown
* M2HW1_BrownTaylor | This program has a hard coded array of sales.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // These are all the hard coded sales from Sales.txt 
            decimal val1 = 1245.67m;
            decimal val2 = 1189.55m;
            decimal val3 = 1098.72m;
            decimal val4 = 1456.88m;
            decimal val5 = 2109.34m;
            decimal val6 = 1987.55m;
            decimal val7 = 1872.36m;

            // This is the array creation that takes in all values
            decimal[] sales = { val1, val2, val3, val4, val5, val6, val7 };

            // This prints out all sales that where hard coded
            Console.WriteLine("All the sales hard-coded:");
            for (int index = 0; index < sales.Length; index++)
            {
                Console.WriteLine(sales[index]);
            };

            // This adds the total of all sales together
            decimal totalSales = 0.00m;
            for (int index = 0; index < sales.Length; index++)
            {
                totalSales += sales[index];
            };

            // Displays the total
            Console.WriteLine("\nThis is the total of all sales: " + totalSales);
            
            // Waits for input from keyboard before closing
            Console.ReadKey();
        }
    }
}

// This is for quick reference
/**
    * 1245.67
    * 1189.55
    * 1098.72
    * 1456.88
    * 2109.34
    * 1987.55
    * 1872.36
*/