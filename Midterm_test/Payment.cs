using System;
namespace Midterm_test
{
    public class Payment:Reciept
    {/*
        public double SubTotal { get; private set; }
        public const double Tax = .06;
        public double GrandTotal { get; private set; }

        
        public double GetTotalCost(double SubTotal)
        {
            double subTotal = SubTotal;
            double tax = subTotal * Tax;
            grandTotal = Math.Round((subTotal + tax), 2, MidpointRounding.AwayFromZero);

            return grandTotal;
        }
        // moved to reciept class
        /// payment options and selection
        
        public void DisplayPayTypes() // displaying pay options, being called by SelectPaymentType method
        {
            string[] paymentOptions = new string[] { "Cash", "Check", "Card" };

            for (int i = 0; i < paymentOptions.Length; i++)
            {
                int paymentNumber = i + 1;
                Console.WriteLine($"{paymentNumber} {paymentOptions[i]}");
            }
        }
        

        public int SelectPaymentType(double totalDue) //passing through total due so that it can be passed to payment methods when selected
        {
            int payType = 0;
            bool isValidPayOpt = false;

            while (isValidPayOpt == false)
            {
                DisplayPayTypes();

                Console.WriteLine("\nPlease enter the number of selected payment type:");
                payType = InputValidation.IsInt();

                if (payType >= 1 && payType <= 3)
                {
                    isValidPayOpt = true;
                    switch (payType)
                    {
                        case 1:
                            CashPayment.CashPay(totalDue);
                            break;
                        case 2:
                            CheckPayment.CheckPay(totalDue);
                            break;
                        case 3:
                            CardPayment.CardPay(totalDue);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Unknown value");
                    }
                }
            }
            return payType;
        }
        */

        /*
        public void GetPaymentInfo(double grandTotal) //passing through total due so that it can be passed to payment methods when selected
        {

        }

        //        public bool NonCashTransaction(double totalDue)
        //        {
        //            bool tenderAccept = false;

        //            while (tenderAccept == false)
        //            {
        //                Console.WriteLine($"\nTo process your payment for {totalDue}: Press 'y'.");
        //                Console.WriteLine("To select a different payment method: Press 'n'.");
        //                Console.WriteLine("To stop shopping and quit the program: Press any other key.");

        //                string processTransaction = InputValidation.IsString(Console.ReadLine());

        //                if (processTransaction == "y")
        //                {
        //                    tenderAccept = true;
        //                    break;
        //                }
        //                if (processTransaction == "n")
        //                {
        //                    SelectPaymentType(totalDue);
        //                    break;
        //                }
        //                else
        //                {
        //                    Console.Write("Thanks for shopping!");
        //                    Environment.Exit(0);
        //                }
        //            }
        //            return tenderAccept;
        //        }
        //    }
        //}
        */
        /*
        public void DisplayPayTypes() // displaying pay options, being called by SelectPaymentType method
        {
            string[] paymentOptions = new string[] { "Cash", "Check", "Card" };

            for (int i = 0; i < paymentOptions.Length; i++)
            {
                int paymentNumber = i + 1;
                Console.WriteLine($"{paymentNumber} {paymentOptions[i]}");
            }
            SelectPaymentType();
        }


        public void SelectPaymentType() //passing through total due so that it can be passed to payment methods when selected
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
                            break;
                        case 2:
                            CheckPayment check = new CheckPayment();
                            check.GetPaymentInfo(GrandTotal);
                            CheckNumber = check.DisplayCheck();
                            break;
                        case 3:
                            CardPayment card = new CardPayment();
                            card.GetPaymentInfo(GrandTotal);
                            card.DisplayCard();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Unknown value");
                    }
                }

            }

        }

        */

    }
}