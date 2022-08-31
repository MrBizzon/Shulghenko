// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int arrayString = EnteringANumber("Введите размеры массивов: ");
int[,] matrix1 = new int[arrayString, arrayString];
int[,] matrix2 = new int[arrayString, arrayString];

int EnteringANumber(string result)
{
    Console.Write(result);
    return int.Parse(Console.ReadLine());
}

void NumberGenerator(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 5);
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

NumberGenerator(matrix1);
NumberGenerator(matrix2);
int[,] matrix3 = new int[arrayString, arrayString];

for (int i = 0; i < arrayString; i++)
{
    for (int j = 0; j < arrayString; j++)
    {
        for (int k = 0; k < arrayString; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("\nПервый массив: ");
PrintingNumbers(matrix1);
Console.WriteLine();
Console.WriteLine("\nВторой массив: ");
PrintingNumbers(matrix2);
Console.WriteLine();
Console.WriteLine("\nПроизведение матриц: ");
PrintingNumbers(matrix3);
