// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// (можно использовать готовую функцию)
Console.Clear();
Console.WriteLine("Введите M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write(Sort(array[m, n]));
Console.WriteLine();

void Sort(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for(int a = 0; a < n; a++)
            {
                if(array[i,a] < array[i, a + 1])
                {
                    int temp = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = temp;
                }
            }
        }
    }
}


