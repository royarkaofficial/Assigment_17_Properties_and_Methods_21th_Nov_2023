using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17_Using_Methods_in_C_
{
    internal class HerbalProduct: Product
    {
        // Additional fields for HerbalProduct
        private string herbsUsed;
        private DateTime mfDate;
        private DateTime expDate;

        // Method to show details (overrides base class method)
        public override void ShowDetails()
        {
            base.ShowDetails(); // Call base class method to display common details
            Console.WriteLine($"Herbs Used: {herbsUsed}");
            Console.WriteLine($"Manufacturing Date: {mfDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Expiry Date: {expDate.ToString("yyyy-MM-dd")}");
        }

        // Method to set information (overrides base class method)
        public override void SetInformation(int id, string name, decimal price)
        {
            base.SetInformation(id, name, price); // Call base class method to set common information

            // Set information specific to HerbalProduct
            Console.Write("Enter Herbs Used: ");
            herbsUsed = Console.ReadLine();

            Console.Write("Enter Manufacturing Date (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime manufacturingDate))
            {
                mfDate = manufacturingDate;
            }
            else
            {
                Console.WriteLine("Invalid date format. Using default date.");
                mfDate = DateTime.MinValue;
            }

            Console.Write("Enter Expiry Date (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime expiryDate))
            {
                expDate = expiryDate;
            }
            else
            {
                Console.WriteLine("Invalid date format. Using default date.");
                expDate = DateTime.MinValue;
            }
        }
    }
}
