// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int NumberOfRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int NumberOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[NumberOfRows, NumberOfColumns];

double[,] array = new double[NumberOfRows, NumberOfColumns];

void RandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write("{0}  ", array[i, j]);
        }
        Console.WriteLine();
    }
}
RandomNumbers(array);
