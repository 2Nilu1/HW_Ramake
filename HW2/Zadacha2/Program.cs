//Задача 13: Напишите программу, которая выводит третью цифру заданного
//числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число ");
string array = Console.ReadLine();
if(array.Length >= 1)
{
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет:(");
}

