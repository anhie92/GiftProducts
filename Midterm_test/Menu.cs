using System;
namespace Midterm_test
{
    public class Menu
    {
        public List<GiftProduct> ListOfProducts { get; set; } = new List<GiftProduct>();

        public List<GiftProduct> GiftList()
        {
            ListOfProducts.Add(new Clothing("T-shirt", "S/M/L", "Onederful and Vibrant T-Shirts",  14.99 ));
            ListOfProducts.Add(new Clothing("Hat", "One Size Fits All", "Baseball caps or knitted hats", 17.99));
            ListOfProducts.Add(new Clothing("Scarf", "One Size Fits All", "Cashmere scarf, various patterns", 12.99));
            ListOfProducts.Add(new Clothing("Sweatshirt", "S/M/L", "Hoodies, zip-ups, and crewneck", 29.99));
            ListOfProducts.Add(new Clothing("Sunglasses", "One Size Fits All", "Men, women, and children styles", 11.99));
            ListOfProducts.Add(new Food("Coffee", "Drink", "Large with hazelnut syrup", 4.75));
            ListOfProducts.Add(new Food("Pop", "Drink", "20 oz bottle", 2.50));
            ListOfProducts.Add(new Food("Candy Bar", "Candy", "Milk or dark chocolate", 3.50));
            ListOfProducts.Add(new Food("Beer", "Drink", "12 oz can of beer, cider, or seltzer", 5.50));
            ListOfProducts.Add(new Novelties("Postcard", "Souvenir", "Various styles, 3x5 inches", 0.50));
            ListOfProducts.Add(new Novelties("Shot Glass", "Souvenir", "You drink from it!", 7.99));
            ListOfProducts.Add(new Novelties("Book", "Literature", "Books on local culture", 15.99));
            ListOfProducts.Add(new Novelties("Magnet", "Souvenir", "Refrigerator magnets", 3));

            return ListOfProducts;
        }
        public void DisplayGiftShopList()
        {
            Console.Clear();
            Console.WriteLine("These are the available items for sale in the gift shop: ");
            for (int i = 0; i < ListOfProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ListOfProducts[i].Name}: ${ListOfProducts[i].Price:c}");
            }

        }


        // made some changes to this method
        public void GetLineTotal(int n, double quantity)
        {

            /////////
            //Console.WriteLine("Please enter the number for the item you wish to purchase.");
            // n = Convert.ToInt32(Console.ReadLine()) - 1;

            //Console.WriteLine("How many would you like to purchase?");
            //quantity = Convert.ToInt32(Console.ReadLine());
            //// put this in program .cs
            double lineTotal = quantity * ListOfProducts[n].Price;

            Console.WriteLine($"{quantity} {ListOfProducts[n].Name}s equals {lineTotal:c}");
        }

        public List<GiftProduct> AddToCart(List<GiftProduct> cart, int n, double quantity)
        {
            
                for(int i =1; i <= quantity; i++)
                {
                    cart.Add(ListOfProducts[n]);
                }
           
            return cart;

        }
    }
}