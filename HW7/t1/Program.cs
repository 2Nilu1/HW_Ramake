// Задача 47. Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.
Console.Clear();
Console.WriteLine("Введите M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];



for (int i = 0; i < m; i++)
{
    Console.WriteLine("Ведите числа через пробел");
    string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < n; j++)
    {
        array[i,j] = Convert.ToDouble(text[j]);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
