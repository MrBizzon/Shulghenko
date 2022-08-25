// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// int[] array = new int[10];

// int[] fil(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(string.Join(", ", array));
//     return array;
// }
// void popo(int[] array)
// {
//     int minus = 0;
//     int plus = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             minus += array[i];
//         else
//             plus += array[i];
//     }
//     Console.WriteLine($"Сумма положительных: {plus}, отрицательных: {minus}");
// }
// popo(fil(array));

//=========================================

// Задайте массив из 8 случайных чисел. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите ваше число");
// int numberFirst = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];

void random(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
        arr[2] = 4;
        arr[1] = 4;
    }
    Console.WriteLine("Выпали случайные числа" + "[{0}]", string.Join(", ", arr));
}

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

int IndexOf(int[] arr, int numberFirst)
{
    int count = arr.Length;
    int index = 0;
    int position = -2;
    while (index < count)
    {
        if (arr[index] == numberFirst)
        {
            position = index;
            // break;
        }
        index++;
    }
    return position;
}

random(array);
// PrintArray(array);
int pos = IndexOf(array, 4);
Console.WriteLine($"Заданное число стоит на {pos + 1}-й позиции");

//=================================================

// / Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число");
string num = Convert.ToString(Console.ReadLine());
      int length = Convert.ToString(num).Length;

Console.WriteLine($"сумма цифр в числе {num} равна {SumOfDigits(num)}");

int SumOfDigits(int number)
{
    int sum = 0;
    int s = number[i];
    for (int i = 0; i < number.Length; i++)
    {
        // s = Convert.ToInt32(numder[i]);
      
        sum = sum + s;
        Console.WriteLine($"{sum}.....{s}");
    }
    return sum;
}
