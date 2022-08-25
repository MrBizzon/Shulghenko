// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int j = 8;
int min = -100,
    max = 100;
int[] registry = new int[j];
random(registry);
sum(registry);

// for (int i = 0; i < registry.Length; i++)
// {
//     int counter = 0;

//     {
//         if (registry[i] % 2 != 0)
//             counter++;
//     }
// }

void random(int[] registry)
{
    for (int i = 0; i < registry.Length; i++)
    {
        registry[i] = new Random().Next(min, max);
    }
    Console.WriteLine("Выпали случайные числа " + "[{0}]", string.Join(", ", registry));
}

void sum(int[] registry)
{
    int count = 0;
    {
        for (int i = 1; i < registry.Length; i += 2)
        {
            count = registry[i] + count;
        }
        Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {count}");
    }
}