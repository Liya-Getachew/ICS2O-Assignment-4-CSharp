// Created by: liya getachew
// Created on: Nov 26 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates total price of user's order
        string topping;
        string size;
        double TAX_RATE = 1.13;
        double toppingPrice = 0;
        double sizePrice = 0;

        Console.WriteLine("Welcome to Donuteria!");
        Console.WriteLine("Insert your prefered box size and topping below.");
        Console.WriteLine();

        Console.Write("box size: ");
        size = Console.ReadLine();

        Console.Write("topping: ");
        topping = Console.ReadLine();

        if (topping == "sprinkles")
        {
            toppingPrice = 1.00;
        }
        else if (topping == "glazed")
        {
            toppingPrice = 2.00;
        } else if (topping == "jam filling")
        {
            toppingPrice = 1.50;
        } else if (topping == "powdered sugar")
        {
            toppingPrice = 1.00;
        } else if (topping == "caramel")
        {
            toppingPrice = 3.00;
        } else 
        {
            toppingPrice = 0.00;
        }

        if (size == "one")
        {
            sizePrice = 1.00;
        }
        else if (size == "six")
        {
            sizePrice = 7.00;
        } else if (size == "twelve")
        {
            sizePrice = 15.00;
        } else 
        {
            sizePrice = 0.00;
        }

        Console.WriteLine("");
        Console.WriteLine("Receipt");
        Console.WriteLine("");

        Console.WriteLine("Item ----- Cost");
        Console.WriteLine(size + " $" + Math.Round(sizePrice, 2));
        Console.WriteLine(topping + " $" + Math.Round(toppingPrice, 2));
        Console.WriteLine("");

        Console.WriteLine("Taxes 13%");

        double totalPrice = ((sizePrice + toppingPrice) * TAX_RATE); 

        Console.WriteLine("Total " + "$" + Math.Round(totalPrice, 2));
        Console.WriteLine("Thanks for purchasing!");

        Console.WriteLine("\nDone.");
    }
}