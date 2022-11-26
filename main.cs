// Created by: liya getachew
// Created on: Nov 26 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function generates a random number from 1-6
        Random random = new System.Random();
        int randomNumber = random.Next(1, 6);
        int randomNumber2 = random.Next(-6, -1);
        string choice;

        Console.WriteLine("Would you rather: positive or negative?");
        Console.WriteLine("enter pos for positive or neg for negative");
        Console.WriteLine();

        Console.Write("your choice: ");
        choice = Console.ReadLine();

        if (choice == "pos")
        {
            Console.WriteLine("Your positive number is: " + randomNumber + ".");
        }
        else
        {
            Console.WriteLine("Your negative number is: " + randomNumber2 + ".");
        }

        Console.WriteLine("\nDone.");
    }
}