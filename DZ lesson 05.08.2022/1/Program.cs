// Homework number 1. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Enter the first number");
int nuamberFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int numberSecond = int.Parse(Console.ReadLine());
if (numberSecond > nuamberFirst)
{
    Console.WriteLine("A large number is " + numberSecond);
}
if (numberSecond < nuamberFirst)
{
    Console.WriteLine("A large number is " + nuamberFirst);
}

if (numberSecond == nuamberFirst)
{
    Console.WriteLine("The numbers are equal");
}