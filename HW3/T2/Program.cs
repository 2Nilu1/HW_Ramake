//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.WriteLine("Введите х первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите у первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите х второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите у второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());

double A = x2 - x1;
double B = y2 - y1;
double C = z1 - z2;

double dist = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками = {dist}");



