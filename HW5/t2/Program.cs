// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] array = new int[10];
Random random = new Random();
int sum = 0;
for( int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-5, 5);
}

Console.WriteLine(string.Join(",", array));
Console.WriteLine(Sum(array));

int Sum(int[] array)
{
   for (int i = 0; i < array.Length; i = i + 2)
   {
        sum = sum + array[i];
   }
    return sum;
}
