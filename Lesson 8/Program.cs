// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] array = new int[3, 4];
void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write("{0}  ", array[i, j]);
        }
        Console.WriteLine();
    }
}
Random(array);
Console.WriteLine();

void ChangeArrayElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
            Console.Write("{0}  ", array[i, j]);
        }

        Console.WriteLine();
    }
}
ChangeArrayElements(array);

// =================================================================

// Задача 1: Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Введите 1-е число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// void element(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//             Console.Write("{0} ", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }
// element(array);
