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
    }
}

int minSumLine = 0;
int sumLine = SumLine(array, 0);
for (int i = 1; i < m; i++)
{
  int tempSumLine = SumLine(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}



int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < n; j++)
    {
        sum += array[i,j];
    }
    return sum;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);
Console.WriteLine($"{minSumLine+1} - строка с наименьшей суммой элементов");