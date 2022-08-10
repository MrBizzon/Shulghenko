// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > 0)
    Console.WriteLine("Введенное число двузначное, третья цифра отсутствует");
if (number > 99)
{
    string str = number.ToString();
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 2)
            Console.Write($"Третьей цифрой числа {number} является {str[i]}");
    }
}
