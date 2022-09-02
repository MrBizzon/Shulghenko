// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

int a = InputInt("Введите размерность 1: ");
int b = InputInt("Введите размерность 2: ");
int c = InputInt("Введите размерность 3: ");
int count = 124;

if (a * b * c > count)
{
    Console.Write("Задайте меньшую размерность");
    return;
}

int[,,] result = CreatingThreeDimensionalArray(a, b, c);

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int k = 0; k < result.GetLength(2); k++)
        {
            Console.WriteLine($"{result[i, j, k]} ({i}, {j}, {k})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] CreatingThreeDimensionalArray(int number1, int number2, int number3)
{
    int[,,] randomArray = new int[number1, number2, number3];
    int[] num = new int[count];
    int counter = 10;
    for (int i = 0; i < num.Length; i++)
        num[i] = counter++;

    for (int i = 0; i < num.Length; i++)
    {
        int random = new Random().Next(0, num.Length);
        int temp = num[i];
        num[i] = num[random];
        num[random] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray.GetLength(2); k++)
            {
                randomArray[i, j, k] = num[valueIndex++];
            }
        }
    }
    return randomArray;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
