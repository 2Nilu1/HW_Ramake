// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
Console.WriteLine("Введите M,N и L");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m, n, l];
Random rnd = new Random();

for (int i = 0; i <m; i++) 
{
    for (int j = 0; j < n; j++)
    {
        for (int a = 0; a < l; a++)
        {
            array[i,j,a] = new Random().Next(0, 10);
        }
    }
}


void Show(int[,,]array)
{
    for (int i = 0; i <m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            for (int a = 0; a < l; a++)
            {
                Console.Write($"{Show(array[i, j, a])}");   
            }
        }
    }
}