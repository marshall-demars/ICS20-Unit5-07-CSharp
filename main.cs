// Created by: Marshall Demars
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program tells uses a loop for multiplication
        int integerOne;
        var total = 0;
        int counter = 0;

        // input
        Console.WriteLine("This program uses a loop for repeated addition");
        Console.WriteLine("");
        Console.WriteLine("You will need to input an integers to be used");
        Console.WriteLine("");
        Console.WriteLine("Please input the first integer:");
        integerOne = Convert.ToInt32(Console.ReadLine());

        // process
        for (counter = 0; counter <= integerOne; counter++) 
        {
            total += counter;
        }
        Console.WriteLine("");
        Console.WriteLine("The number is " + total);
        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}