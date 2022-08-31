﻿// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2
// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

int[,] array = new int[4, 4];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
}

Console.WriteLine();
int temp = 0;
void ReplaseRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
ReplaseRows(array);
PrintArray(array);
//================================================================


// int[,] DelRowColumn(int[,] array)
// {
//     int minRow = 0;
//     int minColmn = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < array[minRow, minColmn])
//             {
//                 minRow = i;
//                 minColmn = j;
//             }
//         }
//     }
//     for (int i = minRow + 1; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i - 1, j] = array[i, j];
//         }
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = minColmn + 1; j < array.GetLength(1); j++)
//         {
//             array[i, j - 1] = array[i, j];
//         }
//     }
//     int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = array[i, j];
//         }
//     }
//     return result;
// }
