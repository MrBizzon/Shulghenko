// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

double MyDistans(double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
}

Console.WriteLine("Введите первую координату:");
double ax = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите вторую координату:");
double bx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третью координату:");
double ay = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите четвертую координату:");
double by = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Чертова дистанция равна: {MyDistans(ax, bx, ay, by)}");