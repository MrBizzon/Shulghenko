// Homework number 3. Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным

Console.WriteLine("Enter the number");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("The entered number is positive");
}
else
{
    Console.WriteLine("The entered number is negative");
}
