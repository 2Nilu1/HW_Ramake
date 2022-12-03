Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = b;
if(a > b) a = max;
{
    Console.Write("max = " + max);
    Console.WriteLine("min = " + min);
}
if(b > a) b = max;
{
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}