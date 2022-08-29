// Напишите программу, которая на вход принимает число и возвращает индексы этого элемента
// или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[4, 4];

void randomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}
randomNumbers(array);

int[] numbersSearch(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (number == arr[i, j])
            {
                int[] array = { i, j };
                return array;
            }
        }
    }
    return null;
}

void printArray(int[] arr)
{
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

int[] index = numbersSearch(array, number);

if (index != null)
{
    Console.Write($"Число {number} находится в массиве под индексами: ");
    printArray(index);
}
else
{
    Console.WriteLine($"Число {number} не существует в этом массиве");
}
