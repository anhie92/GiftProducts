﻿using Midterm_test;

Menu menu = new Menu();
menu.GiftList();

Console.WriteLine("Hello, welcome to the Onederful Gift Shop. Would you like to view the list of items for sale? (y/n)");
string menuReply = Console.ReadLine().ToLower();

if (menuReply == "y")
{
    menu.DisplayGiftShopList();
}

Console.WriteLine("Please enter the number for the item you wish to purchase.");