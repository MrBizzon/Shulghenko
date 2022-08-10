// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    string str = number.ToString();
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 1)
            Console.Write($"Второй цифрой числа {number} является {str[i]}");
    }
}
else
{
    Console.WriteLine("Это число не является трехзначным");
}