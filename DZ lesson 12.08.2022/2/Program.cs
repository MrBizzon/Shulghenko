// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double MyDistans(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
}

Console.WriteLine("Начинаем ввод первой тройки координат. Введите первую координату: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите вторую координату: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третью координату: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Начинаем ввод второй тройки координат. Введите первую координату: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите вторую координату: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третью координату: ");
double bz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками составляет: {MyDistans(ax, bx, ay, by, az, bz)}");