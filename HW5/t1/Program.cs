// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Диапазон трехзначных чисел, ввод случайный.
Console.Clear();
int[] array = new int [10];
Random random = new Random();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 999);
}

Console.WriteLine(string.Join(",", array));
Console.WriteLine(Chet(array));


int Chet(int[]array)
{
    for (int i = 0; i <= array.Length; i ++)
    {
        if (array[i] % 2 == 0 )
        {
            count++;
        }

        else
        {
            i++;
        }
    }return count;
}