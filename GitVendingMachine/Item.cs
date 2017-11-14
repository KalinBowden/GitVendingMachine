using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitVendingMachine
{
    // This class defines an item to be stored and sold in a vending machine
    class Item
    {
        // Class level fields
        private int count;
        private string name;
        private double price;


        // Default constructor
        public Item()
        {

        }

        // Stock with new item
        public Item(string name, int count, double price)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
        }


        // Public properties
        public int Count { get => count; set => count = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }
}
