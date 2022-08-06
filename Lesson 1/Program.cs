
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число!");
int namber = int.Parse(Console.ReadLine());
if (namber > 0)
{
    namber *= namber;
    Console.WriteLine("Число, возведенное в квадрат: " + namber);
}
if (namber < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
        Console.WriteLine("Веден ноль");
}