// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int i = 8;
int[] registry = new int[i];
random(registry);
int counter = 0;

for (int a = 0; a < registry.Length; a++)
    if (registry[a] % 2 == 0) counter++;

void random(int[] registry)
{
    for (int b = 0; b < registry.Length; b++)
    {
        registry[b] = new Random().Next(100, 1000);
    }
}
Console.WriteLine("[{0}]", string.Join(", ", registry));
Console.WriteLine($"Из {registry.Length}-и случайных чисел {counter} чётные");