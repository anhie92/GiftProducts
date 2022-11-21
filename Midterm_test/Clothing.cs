using System;
namespace Midterm_test
{
    public class Clothing : GiftProduct
    {
        public string Size { get; set; }
        public Clothing(string name, string size, string description, double price)
        {
            Name = name;
            Size = size;
            Description = description;
            Price = price;
        }
    }
}

