// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int i = 8;
int min = -10000, max = 10000;
int counter = 0;
int count = 0;
int[] registry = new int[i];
random(registry);
sum(registry);

for (int a = 0; a < registry.Length; a++)
{
    if (registry[a] % 2 != 0)
        counter++;
}

void random(int[] registry)
{
    for (int b = 0; b < registry.Length; b++)
    {
        registry[b] = new Random().Next(min, max);
    }
}

void sum(int[] registry)
{
    for (int c = 1; c < registry.Length; c += 2)
    {
        count = registry[c] + count;
    }
}
Console.WriteLine("Выпали случайные числа " + "[{0}]", string.Join(", ", registry));
Console.WriteLine($"Из {registry.Length}-и случайных чисел {counter} нечётные");
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {count}");
