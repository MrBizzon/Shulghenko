// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[,] namber = new int[arraySize, arraySize];

int i = 0;
int j = 0;

for (int count = 1; count <= arraySize * arraySize; ++count)
{
    namber[i, j] = count;
    if (i <= j + 1 && i + j < arraySize - 1)
        ++j;
    else if (i < j && i + j >= arraySize - 1)
        ++i;
    else if (i >= j && i + j > arraySize - 1)
        --j;
    else
        --i;
}

Console.WriteLine();
Console.WriteLine("Массив заполнен спирально:");

void PrintingNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}  ", array[i, j]);
        }
    }
}
PrintingNumbers(namber);
