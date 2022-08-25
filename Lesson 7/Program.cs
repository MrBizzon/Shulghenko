// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве.
// Элементы массива задаются случайно и лежат в промежутке от -10 до 10
// [1, -5, 8, 4, -9] -> 4.33

int[] array = new int[6];
void random(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine("Случайные числа массива: " + "[{0}]", string.Join(", ", array));
}
random(array);

double sum = 0;
int count = 0;
double counter = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum += array[i];
        count++;
        counter = sum / count;
    }
}
Console.WriteLine($"Сумма положительных числе: {sum}");
Console.WriteLine($"Среднее арифметическое положительных числе: {counter:F2}");
Console.WriteLine();

//================================================================================

// Задача 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.).
// Элементы массива задаются случайно и лежат в промежутке от -10 до 10
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array1 = new int[7];

void random1(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-10, 11);
    }
    Console.WriteLine("[{0}]", string.Join(", ", array1));
}

void revers(int[] array1)
{
    for (int i = 0; i < array1.Length / 2; i++)
    {
        int temp = array1[i];
        array1[i] = array1[array1.Length - i - 1];
        array1[array1.Length - i - 1] = temp;
    }
    Console.WriteLine("[{0}]", string.Join(", ", array1));
}

random1(array1);
revers(array1);
