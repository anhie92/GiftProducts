using System;
namespace Midterm_test
{
    public class Clothing : GiftProduct
    {
        public string Size { get; set; }
        public Clothing(string name, string size, string discription, double price)
        {
            Name = name;
            Size = size;
            Description = discription;
            Price = price;
        }
    }
}

