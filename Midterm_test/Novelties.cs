using System;
namespace Midterm_test
{
	public class Novelties:GiftProduct
	{
        public string ItemType { get; set; }
        public Novelties(string name, string itemType, string discription, double price)
        {
            Name = name;
            ItemType = itemType;
            Description = discription;
            Price = price;
        }

    }
}

