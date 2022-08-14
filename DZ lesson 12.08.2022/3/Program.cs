// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите любое число: ");
int table = Convert.ToInt32(Console.ReadLine());

void Тable(int[] table)
{
    int N = 0;
    int array = table.Length;
    while (N < array)
    {
        table[N] = Convert.ToInt32(Math.Pow(N, 3));
        N++;
    }
}

void PrintSize(int[] together)
{
    int t = together.Length;
    int counter = 1;
    while (counter < t)
    {
        Console.Write(together[counter] + " ");
        counter++;
    }
}

int[] size = new int[table + 1];
Тable(size);
PrintSize(size);