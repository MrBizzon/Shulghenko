// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int NumberOfRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int NumberOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[NumberOfRows, NumberOfColumns];

Console.WriteLine();
void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}
RandomNumbers(array);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{sum / array.GetLength(0):F1} ");
}