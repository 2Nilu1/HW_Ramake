Console.Clear();
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
int M = -N;
while (M <= N)
{
    M++;
    if(M % 2 == 0)
    {
         Console.WriteLine(M++);
    }
}

