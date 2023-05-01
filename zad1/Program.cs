// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double DistantLion3d(double ax, double ay, double az, double bx, double by, double bz)
{
    double line = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    return Math.Round(line, 2);
}

Console.Write("Введите A X:");
double ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите A Y:");
double ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите A Z:");
double az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B X:");
double bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B Y:");
double by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B Z:");
double bz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DistantLion3d(ax, ay, az, bx, by, bz));