// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// ++++++++++++++ РЕШЕНИЕ 1 ++++++++++++++++


int[] A = new int[2];
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Введите число {(i + 1)}");
    A[i] = Convert.ToInt32(Console.ReadLine());
}

double result = array(A[0], A[1]);
Console.WriteLine($"{A[0]} в {A[1]}-й степени равно {result}");
double array(double x1, double y1)
{
    double MyStepen = Math.Pow(x1, y1);
    return MyStepen;
}

// ++++++++++++++++ РЕШЕНИЕ 2 ++++++++++++++++++


double MyStepen(double x1, double x2)
{
    return Math.Pow(x1, x2);
}

Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{x1} в {x2}-й степени равно {MyStepen(x1, x2)}");