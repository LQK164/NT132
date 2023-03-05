using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//Exercise 1: Beginner - Reduce but Grow
//Given a non-empty array of integers, return the result of multiplying the values together in order
//Example: [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
//Code:
public static int Grow(int[] arr)
{
    int mul = 1;
    foreach (int i in arr)
    {
        mul *= i;
    }
    return mul;
}
//Exercise 2: Convert a Boolean to a String
//Implement a function which convert the given boolean value into its string representation.
//Note: Only valid inputs will be given.
//Code:
public static string BooleanToString(bool b)
{
    return Convert.ToString(b);
}
//Excercise 3: Sum of positive
//You get an array of numbers, return the sum of all of the positives ones.
//Example [1,-4,7,12] => 1 + 7 + 12 = 20
//Note: if there is nothing to sum, the sum is default to 0.
//Code: 
public static int PositiveSum(int[] arr)
{
    int sum = 0;
    foreach (int i in arr)
    {
        if (i > 0)
        {
            sum += i;
        }
    }
    return sum;
}
//Exercise 4: Grasshopper - Personalized Message
//Create a function that gives a personalized greeting.
//This function takes two parameters: name and owner.
//Code: 
public static string Greet(string name, string owner)
{
    if (name == owner)
        return "Hello boss";
    else
        return "Hello guest";
}
//Exercise 5: Volume of a Cuboid
//Bob needs a fast way to calculate the volume of a cuboid with three values: the length, width and height of the cuboid.
//Write a function to help Bob with this calculation.
//Code:
public static double GetVolumeOfCuboid(double length, double width, double height)
{
    double volume = length * width * height;
    return volume;
}
//Exercise 6: Rock Paper Scissors
//Let's play! You have to return which player won! In case of a draw return Draw!.
//Examples(Input1, Input2 --> Output):
//"scissors", "paper"-- > "Player 1 won!"
//"scissors", "rock"-- > "Player 2 won!"
//"paper", "paper"-- > "Draw!"
//Code:
public string Rps(string p1, string p2)
{
    if (p1 == p2)
    {
        return "Draw!";
    }
    if (((p1 == "scissors") && (p2 == "paper")) || ((p1 == "rock") && (p2 == "scissors")) ||
    ((p1 == "paper") && (p2 == "rock")))
    {
        return "Player 1 won!";
    }
    else return "Player 2 won!";
}
//Exercise 7: Third Angle of a Triangle
//You are given two interior angles (in degrees) of a triangle.
//Write a function to return the 3rd.
//Note: only positive integers will be tested.
//Code: 
public static int OtherAngle(int a, int b)
{
    int tri = 180;
    return tri - (a + b);
}
//Exercise 8: Will there be enough space
//You have to write a function that accepts three parameters:
//cap is the amount of people the bus can hold excluding the driver.
//on is the number of people on the bus excluding the driver.
//wait is the number of people waiting to get on to the bus excluding the driver.
//If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.
//Usage Examples:
//cap = 10, on = 5, wait = 5-- > 0 # He can fit all 5 passengers
//cap = 100, on = 60, wait = 50-- > 10 # He can't fit 10 of the 50 waiting
//Code:
public static int Enough(int cap, int on, int wait)
{
    if (wait > cap - on)
    {
        return -1 * (cap - on - wait);
    }
    else return 0;
}
// Exercise 9: In this Kata we are passing a number (n) into a function.
//Your code will determine if the number passed is even (or not).
//The function needs to return either a true or false.
//Numbers may be positive or negative, integers or floats.
//Floats with decimal part non equal to zero are considered UNeven for this kata.
//Code:
public bool IsEven(double n)
{
    if (n % 2 == 0)
    {
        return true;
    }
    else return false;
}
//Exercise 10: Grasshopper - Debug say Hello
//The starship Enterprise has run into some problem when creating a program to greet everyone as they come aboard.
//It is your job to fix the code and get the program working again!
//Example output: Hello, Mr. Spock
//Code: 
public static string SayHello(string name)
{
    return "Hello, " + name;
}