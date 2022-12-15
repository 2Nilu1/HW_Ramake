//Задайте двумерный массив (вручную) из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("Введите M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
double sum = 0;
double avg = 0;



for(int i = 0; i < m; i++)
{
    Console.WriteLine("Ведите числа через запятую");
    string[] text = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
    for(int j = 0; j < n; j++)
    {
        array[i,j] = Convert.ToInt32(text[j]);
    }
    Console.WriteLine();
}


for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        sum += array[j,i];
    }
    Console.Write(sum / n + " ");
    sum = 0;
}