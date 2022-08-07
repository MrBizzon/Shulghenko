// Homework number 2. Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter the first number");
int nuamberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number");
int numberthird = Convert.ToInt32(Console.ReadLine());
int max = nuamberFirst;
if (numberSecond > max)
    max = numberSecond;
if (numberthird > max)
    max = numberthird;

{
    Console.WriteLine("Maximum number " + max);
}
