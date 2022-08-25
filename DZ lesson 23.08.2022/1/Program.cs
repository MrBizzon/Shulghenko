// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine($"Какое количество чисел вы желаете ввести?");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

void inputNuMbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю цифру: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int input(int M)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }   
        return count;
}
input(M);
inputNuMbers(M);
Console.WriteLine($"Введено положительных чисел: {input(M)}");
