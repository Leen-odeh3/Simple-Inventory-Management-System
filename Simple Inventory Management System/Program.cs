﻿using System;

namespace Simple_Inventory_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\n1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Search for Product");
                Console.WriteLine("6. Exit");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your choice: ");
                Console.ForegroundColor = ConsoleColor.White;
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");

                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");

                        decimal price;
                        while (!decimal.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid decimal value for the price.");
                            Console.Write("Enter product price: ");
                        }
                        int quantity;
                        Console.Write("Enter product quantity: ");
                        while (!int.TryParse(Console.ReadLine(), out quantity))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer value for the quantity.");
                            Console.Write("Enter product quantity: ");
                        }
                        inventory.AddProduct(name, price, quantity);
                        inventory.DisplaySuccessMessage();
                        break;

                    case "2":
                        inventory.DisplayProducts();
                        break;

                    case "3":
                        Console.WriteLine("Enter the name of the product to edit: ");
                        string productName = Console.ReadLine();
                        inventory.EditProduct(productName);
                        break;

                    case "4":
                        Console.WriteLine("Enter the name of the product to delete: ");
                        string productToDelete = Console.ReadLine();
                        inventory.DeleteProduct(productToDelete);
                        break;

                    case "5":
                        Console.WriteLine("Enter the name of the product to search: ");
                        string productToSearch = Console.ReadLine();
                        inventory.SearchProduct(productToSearch);
                        break;

                    case "6":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Exiting...");
                        Console.ForegroundColor = ConsoleColor.White;
                        return;


                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}