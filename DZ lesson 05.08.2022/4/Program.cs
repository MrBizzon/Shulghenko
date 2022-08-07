// Homework number 4. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Enter a positive number:");
int Number = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("From 0 to " + Number + " even numbers are:");
while (i <= Number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}

if (Number <= 1)
{
    Console.Write("There are no positive numbers in the entered number");
}
