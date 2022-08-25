// Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] array = new int[3, 4];

void random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}  ", array[i, j]);
        }
    }
}
random(array);

void sumElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum += array[i, i];
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на главной диагонале равна {sum}");
}
sumElements(array);
