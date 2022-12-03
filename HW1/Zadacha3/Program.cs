onsole.Clear();
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int module = a % 2;
if(module == 0)
{
    Console.Write("true");
}
else
{
    Console.Write("false");
}