using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject.Models
{
    public class PlayStation4Game : Product
    {
        public PlayStation4Game(int id, string name, int cost, string description, string category, int stockQuantity)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;
            Category = category;
            StockQuantity = stockQuantity;
        }

        public override string Examine()
        {
            return $"Product ID: {Id}, Name: {Name}, Cost: {Cost}kr, Description: {Description}, Category: {Category}, Stock: {StockQuantity}";
        }

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
