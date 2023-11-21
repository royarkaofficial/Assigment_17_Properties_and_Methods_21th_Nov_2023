using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17_Using_Methods_in_C_
{
    internal class Product
    {
        // Fields
        protected int pid;
        protected string pname;
        protected decimal pprice;

        // Method to show details
        public virtual void ShowDetails()
        {
            Console.WriteLine($"Product ID: {pid}");
            Console.WriteLine($"Product Name: {pname}");
            Console.WriteLine($"Product Price: ${pprice}");
        }

        // Method to set information
        public virtual void SetInformation(int id, string name, decimal price)
        {
            pid = id;
            pname = name;
            pprice = price;
        }
    }
}
