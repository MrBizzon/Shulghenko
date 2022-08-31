// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int NumberOfRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int NumberOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[NumberOfRows, NumberOfColumns];

Console.WriteLine("\nРандомный массив: ");

void NumberGenerator(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
}

void PrintingNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write("{0}  ", numbers[i, j]);
        }
    }
}

NumberGenerator(numbers);
PrintingNumbers(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1])
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("\nОтсортированный массив: ");
PrintingNumbers(numbers);
