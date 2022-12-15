// Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает индекс этого элемента
// или же указание, что такого элемента нетЕсли элементов несколько, то выводим позицию каждого.
Console.Clear();
Console.WriteLine("Введите M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Random random = new Random();
int num = array[a,b];

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = random.Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}



int Find(int num)
{
    if(a < m && b < n)
    {
        Console.WriteLine(array[a,b]);
    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
    return array[a,b];
}

Console.WriteLine($"Значение элемента: {Find(num)}");