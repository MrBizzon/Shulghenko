// // Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.WriteLine("Введите первое число:");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst == numberSecond * numberSecond)
{
    Console.WriteLine($"{numberSecond} является кратным от {numberFirst}");
}
else
{
    if (numberSecond == 0)
    {
        Console.WriteLine("На ноль делить нельзя");
    }
    Console.WriteLine($"Остаток этого числа равен {numberFirst = numberFirst / numberSecond}");
}
