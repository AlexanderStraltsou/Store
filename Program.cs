﻿// See https://aka.ms/new-console-template for more information
//Welcome user to the app
//Show available products to the user
//Show what is in the shopping cart to the user
//Ask the user for what they want to buy or if the want to leave the store.
//IF the product the user wants to buy is available...
//Put the product in the shopping cart
//WRemove the product from available products
//ELSE
//Tell the user that the product is not available

List <string> availableProducts = new();

availableProducts.Add("Peanut Butter");
availableProducts.Add("Grapes");
availableProducts.Add("Popcorn");
availableProducts.Add("Soap");
availableProducts.Add("Coffee");
availableProducts.Add("Bread"); 
availableProducts.Add("Apples");
availableProducts.Add("Cabbage");
availableProducts.Add("Tomatoes");
availableProducts.Add("Milk");
availableProducts.Add("Onions");
availableProducts.Add("Butter");
availableProducts.Add("Cheese");

List<string> shoppingCart = new();


WelcomeUserToStore();
PrintAvailableProducts();
PrintShoppingCart();
AskForInput();

void WelcomeUserToStore ()
{
    Console.WriteLine("----------------------");
    Console.WriteLine("WELCOME TO THE STORE!");
    Console.WriteLine("----------------------");
}


void PrintAvailableProducts ()

{
    Console.WriteLine();
    Console.WriteLine("Available products:");
    Console.WriteLine();
    foreach (string availableProduct in availableProducts)
    {
        Console.WriteLine(availableProduct);
    }

}

void PrintShoppingCart()
{
    Console.WriteLine();
    Console.WriteLine("Shopping Cart:");
    Console.WriteLine();

    foreach (string productInShoppingCart in shoppingCart)
    {
        Console.WriteLine(productInShoppingCart);
    }
}

string AskForInput ()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to buy?");
    Console.WriteLine();

    Console.Write("Reply: ");
    string input = Console.ReadLine();

    return input;
}

