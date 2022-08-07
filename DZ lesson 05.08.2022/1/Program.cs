// Homework number 1
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
