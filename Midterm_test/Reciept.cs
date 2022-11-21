using System;
namespace Midterm_test
{
	public class Reciept
	{

        public double SubTotal { get; private set; }
        public const double TaxAmount = .06;
        public double Tax { get; private set; }
        public double GrandTotal { get; private set; }
       



        public void GetTotalCost(List<GiftProduct> cart)
        {
            SubTotal = cart.Sum(x=>x.Price);
            Tax = SubTotal * TaxAmount;
            GrandTotal = Math.Round((SubTotal + Tax), 2, MidpointRounding.AwayFromZero);
        }

        public void DisplayPayTypes() // displaying pay options, being called by SelectPaymentType method
        {
            string[] paymentOptions = new string[] { "Cash", "Check", "Card" };

            for (int i = 0; i < paymentOptions.Length; i++)
            {
                int paymentNumber = i + 1;
                Console.WriteLine($"{paymentNumber} {paymentOptions[i]}");
            }
           
        }


        public void SelectPaymentType(List<GiftProduct> cart) //passing through total due so that it can be passed to payment methods when selected
        {
            int payType = 0;
            bool isValidPayOpt = false;

            while (isValidPayOpt == false)
            {


                Console.WriteLine("\nPlease enter the number of selected payment type:");
                payType = InputValidation.IsInt();

                if (payType >= 1 && payType <= 3)
                {
                    isValidPayOpt = true;
                    switch (payType)
                    {
                        case 1:
                            CashPayment cash = new CashPayment();
                            cash.GetPaymentInfo(GrandTotal);
                            Console.Clear();
                            DisplayReciept(cart);
                            Console.WriteLine(DisplayCash(cash));
                            
                            break;
                        case 2:
                            CheckPayment check = new CheckPayment();
                            check.GetPaymentInfo(GrandTotal);
                            Console.Clear();
                            DisplayReciept(cart);
                            Console.WriteLine(DisplayCheck(check));
                            
               
                            break;
                        case 3:
                            CardPayment card = new CardPayment();
                            card.GetPaymentInfo(GrandTotal);
                            Console.Clear();
                            DisplayReciept(cart);
                            Console.WriteLine(DisplayCard(card));
                            break;
                            
                        default:
                            throw new ArgumentOutOfRangeException("Unknown value");
                    }
                }

            }

        }


      
        // display credit card receipt
        public string DisplayCard(CardPayment card)
        {

            return $"{GrandTotal:c} paid by credit card with credit card #{card.LastFour}\n";
        }
        // display check on reciept
        public string DisplayCheck(CheckPayment check)
        {
            return $"{GrandTotal:c} paid by check \n with check #{check.CheckNum}\n";
        }
        // display cash receipt
        public string DisplayCash(CashPayment cash)
        {
            return $"{GrandTotal:c} paid with {cash.CashTendered:c} cash. Your change is {cash.ChangeDue:C}\n";
        }


        public void DisplayReciept(List<GiftProduct> cart)
		{
           
            foreach (GiftProduct item in cart)
			{
				Console.WriteLine(String.Format("{0,-10} | {1,-10}", $"{item.Name}", $"{item.Price:c}"));
	
				
			}

            GetTotalCost(cart);
            Console.WriteLine(String.Format("{0,20} | {1,-10}", $"Subtotal", $"{SubTotal:c}"));
            Console.WriteLine(String.Format("{0,20} | {1,-10}", $"Tax", $"{Tax:c}"));
            Console.WriteLine(String.Format("{0,20} | {1,-10}", $"Total", $"{GrandTotal:c}"));
           
        }

        public void DisplayTotal(List<GiftProduct> cart)
        {
            GetTotalCost(cart);
            DisplayReciept(cart);
            DisplayPayTypes();
            SelectPaymentType(cart);
        }





    }
}

