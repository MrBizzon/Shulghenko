// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] intersection = new double[2];
double[,] ratio = new double[2, 2];

void inputCoefficients()
{
    for (int i = 0; i < ratio.GetLength(0); i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю пару коэффициентов");
        for (int j = 0; j < ratio.GetLength(1); j++)
        {
            if (j == 0)
                Console.WriteLine($"Введите коэффициент k: ");
            else
                Console.WriteLine($"Введите коэффициент b: ");
            ratio[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Equation(double[,] ratio)
{
    intersection[0] = (ratio[1, 1] - ratio[0, 1]) / (ratio[0, 0] - ratio[1, 0]);
    intersection[1] = intersection[0] * ratio[0, 0] + ratio[0, 1];
    return intersection;
}

void OutputSolution(double[,] ratio)
{
    if (ratio[0, 0] == ratio[1, 0] && ratio[0, 1] == ratio[1, 1])
    {
        Console.WriteLine($"Прямые не пересекуться, поскольку параллельны");
    }
    else
    {
        Equation(ratio);
        Console.WriteLine($"Прямые пересекуться в точке с координатами: \n{intersection[0]:F2}, {intersection[1]:F2}");
    }
}

inputCoefficients();
OutputSolution(ratio);
