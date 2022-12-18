//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
Console.WriteLine("Введите число a, a > 0");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b, b > 0");
int b = Convert.ToInt32(Console.ReadLine());

if(a > 0 && b > 0)
{
    Console.Write("true");
}
else
{
    Console.WriteLine("Неверный формат данных!");
}


int Fun(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    if (b == 0)
    {
        return Fun(a - 1, 1);
    }
    else
    {
        return Fun(a - 1, Fun(a, b - 1));
    }
}

Console.Write($"Функция акермана = {Fun(a,b)}");