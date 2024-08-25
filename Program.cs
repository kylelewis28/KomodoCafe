using KomodoCafe.Models;
using KomodoCafe.Repositories;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        MenuRepository repo = new MenuRepository();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Komodo Café Menu Management");
            Console.WriteLine("1. Add Menu Item");
            Console.WriteLine("2. Update Menu Item");
            Console.WriteLine("3. Delete Menu Item");
            Console.WriteLine("4. View All Menu Items");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddMenuItem(repo);
                    break;
                case "2":
                    UpdateMenuItem(repo);
                    break;
                case "3":
                    DeleteMenuItem(repo);
                    break;
                case "4":
                    ViewAllMenuItems(repo);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddMenuItem(MenuRepository repo)
    {
        //adding a menu item
    }

    static void UpdateMenuItem(MenuRepository repo)
    {
        //updating item
    }

    static void DeleteMenuItem(MenuRepository repo)
    {
        // deleti item
    }

    static void ViewAllMenuItems(MenuRepository repo)
    {
        var items = repo.GetAllMenuItems();
        foreach (var item in items)
        {
            Console.WriteLine($"#{item.MealNumber}: {item.MealName} - {item.Description} - ${item.Price}");
        }
    }
}
