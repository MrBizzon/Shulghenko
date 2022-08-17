// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// А потом выдаёт произведение чисел от 1 до А.
// 4  -> 24

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Summ(int n)
{
    int summ = 0;
    for (int i = 1; i <= n; i++)
    {
        summ = summ + i;
    }
    return summ;
}

int Product(int n)
{
    int prod = 1;
    for (int i = 1; i <= n; i++)
    {
        prod = prod * i;
    }
    return prod;
}
Console.WriteLine($"Сумма {Summ(n)}");
Console.WriteLine($"Произведение {Product(n)}");
