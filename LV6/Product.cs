using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class Product
    {
        public string Description { get; private set; }
        public double Price { get; private set; }

        public Product(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Description + ":\n" + this.Price;
        }

        private int GetFrameWidth()
        {
            return this.Description.Length;
        }
        private string GetRule(char c) { return new string(c, this.GetFrameWidth()); }

        public void Show()
        {
            Console.WriteLine(this.GetRule('#'));
            Console.WriteLine(this.Description);
            Console.WriteLine(this.GetRule('-'));
            Console.WriteLine(this.Price);
            Console.WriteLine(this.GetRule('#'));
        }
    }
}
