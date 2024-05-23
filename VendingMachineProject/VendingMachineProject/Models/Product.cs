using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject.Models
{
    public abstract class Product
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cost { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public int StockQuantity { get; set; }

            public abstract string Examine();
            public abstract string Use();
        
    }
}
