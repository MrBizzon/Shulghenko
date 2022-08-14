// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 0, remains, N;
N = number;
if (number > 99999 || number < 9999)
    Console.WriteLine("Введеное число не является пятизначным");
else
{
    while (number > 0)
    {
        remains = number % 10;
        counter = counter * 10 + remains;
        number = number / 10;
    }

    if (counter != N)
        Console.WriteLine("Введеное число не является палиндромом");
    else
        Console.WriteLine("Введенное число является палиндромом");
}
