// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

int size1 = InputInt("Введите размерность 1: ");
int size2 = InputInt("Введите размерность 2: ");
int size3 = InputInt("Введите размерность 3: ");
int count = 124;

if (size1 * size2 * size3 > count)
{
    Console.Write("Задайте меньшую размерность");
    return;
}

int[,,] result = CreatingThreeDimensionalArray(size1, size2, size3);

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

int[,,] CreatingThreeDimensionalArray(int size1, int size2, int size3)
{
    int[,,] randomArray = new int[size1, size2, size3];
    int[] meaning = new int[count];
    int number = 10;
    for (int i = 0; i < meaning.Length; i++)
        meaning[i] = number++;

    for (int i = 0; i < meaning.Length; i++)
    {
        int randomInd = new Random().Next(0, meaning.Length);
        int temp = meaning[i];
        meaning[i] = meaning[randomInd];
        meaning[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray.GetLength(2); k++)
            {
                randomArray[i, j, k] = meaning[valueIndex++];
            }
        }
    }
    return randomArray;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
