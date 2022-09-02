// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m == n)
{
    Console.WriteLine("\nПервое число не должно равняться второму\n");
}
else
{
    int i = m;
    Console.Write($"\nНатуральные числа в промежутке от {m} до {n} -> ");
    void Size(int m, int n)
    {
        Console.Write($"{i} ", "");
        if (i >= n)
            return;
        i++;
        Size(m, n);
    }

    void Main(string[] args)
    {
        Size(m, n);
    }
    Main(args);
}
