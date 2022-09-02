// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m >= n)
{
    Console.WriteLine("\nВторое число должно быть больше первого\n");
}
else
{
    int i = m;
    int sum = 0;

    void Size(int m, int n)
    {
        if (i >= n)
            return;

        i++;
        Size(m, n);
    }
    sum = (m + n) * (n - m + 1) / 2;

    Console.Write($"Сумма чисел в промежутке от {m} до {n} = ");

    void PrintingSum(int sum)
    {
        Console.Write(sum);
    }
    PrintingSum(sum);
}
