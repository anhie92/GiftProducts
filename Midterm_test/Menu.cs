using System;
namespace Midterm_test
{
    public  class Menu
    {
        public List<GiftProduct> ListOfProducts { get; set; } = new List<GiftProduct>();//added missing portion of this

        public List<GiftProduct> GiftList()
        {
            //List<GiftProduct> list = new List<GiftProduct>(); this line of code not needed
            ListOfProducts.Add(new Clothing("1. T-shirt","S/M/L", "Onederful and Vibrant T-Shirts", 14.99));
            ListOfProducts.Add(new Clothing("2. Hat", "One Size Fits All", "Baseball caps or knitted hats", 17.99));
            ListOfProducts.Add(new Clothing("3. Scarf", "One Size Fits All", "Cashmere scarf", 12.99));
            ListOfProducts.Add(new Clothing("4. Sweatshirt", "S/M/L", "This Sweat shirt had a Onederous design", 29.99));
            ListOfProducts.Add(new Clothing("5. Sunglasses", "One Size Fits All", "Men, women, and children styles", 11.99));
            ListOfProducts.Add(new Food("6. Coffee", "Drink", "Large with hazelnut syrup", 4.75));
            ListOfProducts.Add(new Food("7. Pop", "Drink", "20 oz bottle", 2.50));
            ListOfProducts.Add(new Food("8. Candy Bar", "Candy", "Milk or dark chocolate", 3.50));
            ListOfProducts.Add(new Food("9. Beer", "Drink", "Corona Exta 12oz Bottle", 5.50));
            ListOfProducts.Add(new Novelties("10. Postcard", "sending a message", "Various styles", 0.50));
            ListOfProducts.Add(new Novelties("11. Shot Glass", "Drinking apparatus", "You drink from it!", 7.99));
            ListOfProducts.Add(new Novelties("12. Book", "Entertainment", "Books on local culture", 15.99));
            ListOfProducts.Add(new Novelties("13. Magnet", "Memorabilia", "Refrigerator magnets", 3));
            //Changed all of the items to their actual Classes instead of using GiftProduct for All
            return ListOfProducts;
        }
        public void DisplayGiftShopList(/*List<string> list*/)//Parameter not needed
        {
            Console.Clear();
            Console.WriteLine("These are the available items for sale in the gift shop: ");
            foreach (/*string changed to*/ GiftProduct product in ListOfProducts) //GiftList() not needed used ListOfProducts instead
            {
                //Console.WriteLine(product.Name + "," + product.Price);
                //used interpolation for this
                Console.WriteLine($"{product.Name}, {product.Description}, {product.Price:c}");
            }

        }
    }
}