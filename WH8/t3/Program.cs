// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine("Введите M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] mat1 = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat1[i, j] = new Random().Next(0, 10);
        Console.Write($"{mat1[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите X и Z");
int x = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int[,] mat2 = new int[x,z];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < z; j++)
    {
        mat2[i, j] = new Random().Next(0, 10);
        Console.Write($"{mat2[i, j]} ");
    }
    Console.WriteLine();
}

int[,] res = new int[m,x];//подсмотрел

void MatCom(int[,] mat1, int[,] mat2, int[,] res)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; i < x; i++)
        {
            int sum = 0;
            for (int a = 0; a < n; a++)
            {
                sum += mat1[i,a] * mat2[a, j];
            }
            res[i,j] = sum;
        }
    }
}


void WriteArray (int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

MatCom(mat1, mat2, res);
Console.WriteLine();
WriteArray(res);

