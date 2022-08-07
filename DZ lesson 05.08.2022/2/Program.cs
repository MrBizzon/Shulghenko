// Homework number 2
Console.WriteLine("Enter the first number");
int nuamberFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int numberSecond = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number");
int numberthird = int.Parse(Console.ReadLine());
int max = nuamberFirst;
if (numberSecond > max)max = numberSecond;
if (numberthird > max)max = numberthird;
Console.WriteLine("Maximum number " + max);