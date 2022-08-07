Console.WriteLine("Ведите цифру: ");

int numbers = int.Parse(Console.ReadLine());

if (numbers == 1)
{
Console.WriteLine("Понедельник");
}

if (numbers == 2)
{
   Console.WriteLine("Вторник");
}

if (numbers == 3)
{
   Console.WriteLine("Среда");
}

if (numbers == 4)
{
   Console.WriteLine("Четверг");
}

if (numbers > 7 || numbers < 1)
{
   Console.WriteLine("Введите число от 1 до 7);
}


// else
// {
//     Console.WritLine("Такого дня недели нет");
// }