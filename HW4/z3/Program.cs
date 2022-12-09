//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.Clear();
int[] num = new int[8];
for (int i = 0; i < 8; i++)
{
    num[i] = new Random().Next(1,9);
    Console.Write(num[i] + ",");
}
