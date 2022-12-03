Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine(a + ">" + b);
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else;
{
    Console.WriteLine(b + ">" + a);
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}