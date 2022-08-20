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

Console.WriteLine("Введите ваше число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];
random(array);
number(array);
void random(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    Console.WriteLine("Выпали случайные числа " + "[{0}]", string.Join(", ", array));
}

void number(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (numberFirst == array[i])
            Console.WriteLine($"Число {numberFirst} в масиве присутствует");
        
       if (numberFirst != array[i])
            Console.Write($"Число {numberFirst} в масиве отсутствует");
        
    }
}
// number(random(array));
