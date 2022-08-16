// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int N, MySum = 0;

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());
while (N >= 1)
{
    MySum += N % 10;
    N = (N - N % 10) / 10;
}
Console.WriteLine($"Сумма всех цифр числа равна {MySum}");