// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine($"Какое количество чисел вы желаете ввести?");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];

void InputNuMbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю цифру: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Input(int M)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }   
        return count;
}
Input(M);
InputNuMbers(M);
Console.WriteLine($"Введено положительных чисел: {Input(M)}");
