// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] array = new int[10];

int[] fil(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}
void popo(int[] array)
{
    int minus = 0;
    int plus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            minus += array[i];
        else
            plus += array[i];
    }
    Console.WriteLine($"Сумма положительных: {plus}, отрицательных: {minus}");
}
popo(fil(array));
