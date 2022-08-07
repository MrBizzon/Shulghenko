// Homework number 4
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
