using System;
namespace Midterm_test
{
    public class GiftProduct
        //reason why inheritences were not working "GiftProduct" did not have a "S "and the child classes had a "s"
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


       
        /*
        public virtual GiftProduct(string name, string category, string description, double price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
        }
        */
        
    }


}
