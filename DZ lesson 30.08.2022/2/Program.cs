// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[,] namber = new int[arraySize, arraySize];

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

NumberGenerator(namber);
PrintingNumbers(namber);
Console.WriteLine();

void SumOfLines(int[,] arr)
{
    int index = 0,
        minimum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            count += arr[i, j];
        }
        if (i == 0)
        {
            minimum = count;
        }
        else if (count < minimum)
        {
            minimum = count;
            index = i;
        }
    }

    Console.WriteLine($"\nНа {index + 1}-й строке находится минимальная сумма элементов: {minimum}");
}

SumOfLines(namber);
