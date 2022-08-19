// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] registry = new double[5];
random(registry);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < registry.Length; a++)
{
    if (registry[a] > max)
    {
        max = registry[a];
    }
    if (registry[a] < min)
    {
        min = registry[a];
    }
}

void random(double[] registry)
{
    for (int i = 0; i < registry.Length; i++)
    {
        registry[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

Console.WriteLine("[{0}]", string.Join(", ", registry));
Console.WriteLine($"Разница составляет: {max} - {min} = {max - min}");
