// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Intersection = new double[2];
double[,] Ratio = new double[2, 2];

void inputCoefficients()
{
    for (int i = 0; i < Ratio.GetLength(0); i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю пару коэффициентов");
        for (int j = 0; j < Ratio.GetLength(1); j++)
        {
            if (j == 0)
                Console.WriteLine($"Введите коэффициент k: ");
            else
                Console.WriteLine($"Введите коэффициент b: ");
            Ratio[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] equation(double[,] Ratio)
{
    Intersection[0] = (Ratio[1, 1] - Ratio[0, 1]) / (Ratio[0, 0] - Ratio[1, 0]);
    Intersection[1] = Intersection[0] * Ratio[0, 0] + Ratio[0, 1];
    return Intersection;
}

void outputSolution(double[,] Ratio)
{
    if (Ratio[0, 0] == Ratio[1, 0] && Ratio[0, 1] == Ratio[1, 1])
    {
        Console.WriteLine($"Прямые не пересекуться, поскольку параллельны");
    }
    else
    {
        equation(Ratio);
        Console.WriteLine($"Прямые пересекуться в точке с координатами: \n{Intersection[0]:F2}, {Intersection[1]:F2}");
    }
}

inputCoefficients();
outputSolution(Ratio);
