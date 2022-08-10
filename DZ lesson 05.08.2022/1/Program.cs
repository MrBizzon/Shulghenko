// Homework number 1. Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Enter the first number:");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberSecond > numberFirst)
{
    Console.WriteLine($"A large number is {numberSecond}");
}
if (numberSecond < numberFirst)
{
    Console.WriteLine($"A large number is {numberFirst}");
}

if (numberSecond == numberFirst)
{
    Console.WriteLine("The numbers are equal");
}
