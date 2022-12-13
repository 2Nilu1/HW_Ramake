// Pflfxf 41.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.
Console.Clear();
Console.WriteLine("Введите числа через пробел");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //подсмотрел
int count = 0;
int Mzero(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }return count;
}
Console.WriteLine($"Кол-во положительных чиесл = {Mzero(array)}");