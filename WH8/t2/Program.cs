// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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


Console.WriteLine($"{MinSumLine(array[m,n])} {SumLine(array[m,n])}");



int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 0; j < n; j++)
    {
        sum = array[i,j];
    }
    return sum;
}


int MinSumLine(int[,] array, int i)
{
    int minsum = array[i,0];
    for (int j = 0; j < n; j++)
    {
        int tempsum = array[i,0];
        if(minsum > tempsum)
        {
            minsum = tempsum;
            minsum = i;
        }
    }return minsum;

}
