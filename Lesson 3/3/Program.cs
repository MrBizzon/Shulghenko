// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер четверти плоскости, в которой находится эта точка
// и показывает диапазон возможных координат точек в этой четверти (x и y).
// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0

double MyRange(double x, double y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x > 0 && y < 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x < 0 && y > 0)
        return 4;
return 0;
}

Console.WriteLine("Введите первую координату:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату:");
double y = Convert.ToDouble(Console.ReadLine());
double result = MyRange(x, y);
if (result == 0) Console.WriteLine("dfnbn");
Console.WriteLine($"Точка находится в четверти № {result}");


// Console.WriteLine("Введите первую координату:");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите вторую координату:");
// double y = Convert.ToDouble(Console.ReadLine());

// if (x > 0 && y > 0)
//     Console.WriteLine("1 Четверть");
// if (x > 0 && y < 0)
//     Console.WriteLine("2 Четверть");
// if (x < 0 && y < 0)
//     Console.WriteLine("3 Четверть");
// if (x < 0 && y > 0)
//     Console.WriteLine("4 Четверть");
// if (x == 0 || y == 0)
//     Console.WriteLine("X или Y не могут быть равны 0");
