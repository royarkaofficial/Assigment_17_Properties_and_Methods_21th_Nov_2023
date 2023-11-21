using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17_Using_Methods_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of HerbalProduct class
            HerbalProduct herbalProduct = new HerbalProduct();

            // Take user input to set information for HerbalProduct
            Console.Write("Enter Product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            herbalProduct.SetInformation(productId, productName, productPrice);

            // Display details of HerbalProduct
            Console.WriteLine("Product Details:");
            herbalProduct.ShowDetails();
        }
    }
}