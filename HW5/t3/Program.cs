// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 69.4 -22 0.4 78] ->56
// Диапазон любой, ввод зависит от пользователя. (размер, значения)
Console.Clear();
//Console.WriteLine("Введите длину массива ");
//int len = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите диапазон рандома, через запятую ");
double[] array = new double[6];
Random random = new Random();
double min = 0;
double max = 0;
//Random random = new Random(Console.ReadLine( , ));

for(int i = 0; i <array.Length; i++)
{
    array[i] = random.Next(-30, 30);
}

Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Максимальное значение = {Max(array)}, минимальное = {Min(array)}");
Console.WriteLine($"Разница = {Max(array) - Min(array)}");


double Max(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else
        {
            i++;
        }
    }
    return max;
}


double Min(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        else
        {
            i++;
        }
    }
    return min;
}
