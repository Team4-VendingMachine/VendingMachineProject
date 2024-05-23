using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject.Models
{
    // NintendoSwitchGame inherits from the abstract class Product
    public class NintendoSwitchGame : Product
    {
        // Constructor to initialize a new NintendoSwitchGame object
        public NintendoSwitchGame(int id, string name, int cost, string description, string category, int stockQuantity)
        {
            // Initialize properties inherited from the Product class
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;
            Category = category;
            StockQuantity = stockQuantity;
        }

        // Override the abstract method Examine to provide product details
        public override string Examine()
        {
            return $"Product ID: {Id}, Name: {Name}, Cost: {Cost}kr, Description: {Description}, Category: {Category}, Stock: {StockQuantity}";
        }

        // Override the abstract method Use to provide a usage message based on the category
        public override string Use()
        {
            return Category switch
            {
                "Action" => "Enjoy the virtual fight and do not try it with others.",
                "Horror" => "Experience a real horror game.",
                "Family" => "Enjoy playing together with family.",
                _ => "Enjoy your game."
            };
        }
    }
    
}


